using System.Configuration;
using System.Drawing;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace vMet
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient = new HttpClient();

        private Graphics g;

        public WeatherData? Weather { get; private set; }
        public int SelectedRunway { get; private set; } = -1;

        private int elapsedSeconds = 0;
        private int refreshSeconds = 600;

        public Form1()
        {
            InitializeComponent();
            startTimer();
            fetchData();
            timer1.Interval = 1000; // 1 second
            //timer1.Start();
        }

        private void startTimer()
        {
            elapsedSeconds = 0;
            timer1.Start();
            statusTxt.Text = "Running";
            progBar.Visible = true;
            timeRemainingTxt.Visible = true;
        }

        private void stopTimer()
        {
            timer1.Stop();
            statusTxt.Text = "Stopped";
            progBar.Visible = false;
            timeRemainingTxt.Visible = false;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            
            progBar.Value = elapsedSeconds;
            progBar.Maximum = refreshSeconds;

            int remainingSeconds = refreshSeconds - elapsedSeconds;
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;
            timeRemainingTxt.Text = $"Refresh in: {minutes:D2}:{seconds:D2}";

            if (elapsedSeconds >= refreshSeconds)
            {
                elapsedSeconds = 0;
                fetchData();
            }
        }

        private async void fetchData()
        {
            try
            {
                string apiKey = ConfigurationManager.AppSettings["OpenWeatherMapApiKey"];
                
                if (apiKey.Equals("")) 
                {
                    stopTimer();
                    return; 
                }

                string url = "https://api.openweathermap.org/data/2.5/weather?lat=53.7929&lon=-1.2241&appid=" + apiKey;
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                //if (true)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    //string jsonResponse = "{\"coord\":{\"lon\":-1.2241,\"lat\":53.7929},\"weather\":[{\"id\":804,\"main\":\"Clouds\",\"description\":\"overcast clouds\",\"icon\":\"04d\"}],\"base\":\"stations\",\"main\":{\"temp\":295.45,\"feels_like\":295.43,\"temp_min\":294.27,\"temp_max\":296.77,\"pressure\":1020,\"humidity\":65,\"sea_level\":1020,\"grnd_level\":1017},\"visibility\":10000,\"wind\":{\"speed\":4.5,\"deg\":97,\"gust\":5.61},\"clouds\":{\"all\":97},\"dt\":1715442284,\"sys\":{\"type\":2,\"id\":2091861,\"country\":\"GB\",\"sunrise\":1715400559,\"sunset\":1715457198},\"timezone\":3600,\"id\":2638027,\"name\":\"Sherburn in Elmet\",\"cod\":200}";
                    System.Diagnostics.Debug.WriteLine(jsonResponse);
                    Weather = JsonSerializer.Deserialize<WeatherData>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    // Update fields with data
                    UpdateFields(Weather);
                }
                else
                {
                    // Handle unsuccessful response
                    stopTimer();
                    int statusCode = (int)response.StatusCode;
                    string userFriendlyMessage = "Error accessing OpenWeatherMap API:" + Environment.NewLine + GenerateUserFriendlyMessage(statusCode);
                    MessageBox.Show(userFriendlyMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                stopTimer();
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private static string GenerateUserFriendlyMessage(int statusCode)
        {
            switch (statusCode)
            {
                case 400:
                    return "There was a problem with the request. Please check your input and try again.";
                case 401:
                    return "You are not authorized to access this resource. Please check your credentials.";
                case 403:
                    return "You do not have permission to access this resource.";
                case 404:
                    return "The requested resource was not found.";
                case 500:
                    return "There was an internal server error. Please try again later.";
                case 502:
                    return "Bad gateway. The server received an invalid response from the upstream server.";
                case 503:
                    return "The service is unavailable. Please try again later.";
                case 504:
                    return "The request timed out. Please try again later.";
                default:
                    return "An unexpected error occurred (" + statusCode + "). Please try again later.";
            }
        }

        private void UpdateFields(WeatherData data)
        {
            fetchedLocalTxt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " local";
            dataLocalTxt.Text = data.dateTime.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss") + " local";
            //windDirTxt.Text = data.Wind.Deg.ToString("000");
            windDirTxt.Text = data.WindDirDegs.ToString("000") + " (" + data.Wind.Deg.ToString("000") + ")";
            //windDirTxt.Text = ((int)Math.Round(data.Wind.Deg / 10.0) * 10).ToString("000");
            windSpdTxt.Text = data.WindSpeedKnots.ToString();
            gustTxt.Text = data.WindGustKnots.ToString();
            tempTxt.Text = data.TemperatureCelsius.ToString();
            qnhTxt.Text = data.Main.Sea_Level.ToString();
            qfeTxt.Text = (data.Main.Sea_Level - 1).ToString();
            visibilityTxt.Text = data.Visibility.ToString();
            sunriseLocalTxt.Text = data.Sunrise.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss") + " local";
            sunsetLocalTxt.Text = data.Sunset.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss") + " local";

            int r01hw = GetHeadWind(01, data.WindDirDegs, data.WindSpeedKnots);
            int r06hw = GetHeadWind(06, data.WindDirDegs, data.WindSpeedKnots);
            int r10hw = GetHeadWind(10, data.WindDirDegs, data.WindSpeedKnots);
            int r19hw = GetHeadWind(19, data.WindDirDegs, data.WindSpeedKnots);
            int r24hw = GetHeadWind(24, data.WindDirDegs, data.WindSpeedKnots);
            int r28hw = GetHeadWind(28, data.WindDirDegs, data.WindSpeedKnots);

            int maxHeadWind = Math.Max(r01hw, Math.Max(r06hw, Math.Max(r10hw, Math.Max(r19hw, Math.Max(r24hw, r28hw)))));

            int r01cw = GetCrossWind(01, data.WindDirDegs, data.WindSpeedKnots);
            int r06cw = GetCrossWind(06, data.WindDirDegs, data.WindSpeedKnots);
            int r10cw = GetCrossWind(10, data.WindDirDegs, data.WindSpeedKnots);
            int r19cw = GetCrossWind(19, data.WindDirDegs, data.WindSpeedKnots);
            int r24cw = GetCrossWind(24, data.WindDirDegs, data.WindSpeedKnots);
            int r28cw = GetCrossWind(28, data.WindDirDegs, data.WindSpeedKnots);


            rb01.Text = "01 (H:" + r01hw + " C:" + r01cw + ")";
            rb06.Text = "06 (H:" + r06hw + " C:" + r06cw + ")";
            rb10.Text = "10 (H:" + r10hw + " C:" + r10cw + ")";
            rb19.Text = "19 (H:" + r19hw + " C:" + r19cw + ")";
            rb24.Text = "24 (H:" + r24hw + " C:" + r24cw + ")";
            rb28.Text = "28 (H:" + r28hw + " C:" + r28cw + ")";

            HighlightRadioButton(rb01, r01hw, maxHeadWind);
            HighlightRadioButton(rb06, r06hw, maxHeadWind);
            HighlightRadioButton(rb10, r10hw, maxHeadWind);
            HighlightRadioButton(rb19, r19hw, maxHeadWind);
            HighlightRadioButton(rb24, r24hw, maxHeadWind);
            HighlightRadioButton(rb28, r28hw, maxHeadWind);

            this.Invalidate();
            // Update your form fields based on the data
            // Example:
            // textBox1.Text = data.SomeProperty;
            // ...
        }

        private void HighlightRadioButton(RadioButton radioButton, int headWind, int maxHeadWind)
        {
            if (headWind == maxHeadWind)
            {
                radioButton.Font = new Font(radioButton.Font, FontStyle.Bold);
                radioButton.ForeColor = Color.Green;
            }
            else
            {
                radioButton.Font = new Font(radioButton.Font, FontStyle.Regular);
                radioButton.ForeColor = Color.Black;
            }
        }

        private int GetHeadWind(int runwayNumber, double windDirectionDegrees, double windSpeedKnots)
        {
            // Runway heading is runway number * 10
            double runwayHeadingDegrees = runwayNumber * 10;

            // Calculate the angle between the wind direction and the runway heading
            double windRelativeAngleDegrees = windDirectionDegrees - runwayHeadingDegrees;

            // Convert the relative angle to radians for trigonometric calculations
            double windRelativeAngleRadians = windRelativeAngleDegrees * (Math.PI / 180.0);

            // Calculate the headwind component using the cosine of the relative angle
            double headWindComponent = windSpeedKnots * Math.Cos(windRelativeAngleRadians);

            // Round to the nearest whole number and return as an integer
            return (int)Math.Round(headWindComponent);
        }

        private int GetCrossWind(int runwayNumber, double windDirectionDegrees, double windSpeedKnots)
        {
            // Runway heading is runway number * 10
            double runwayHeadingDegrees = runwayNumber * 10;

            // Calculate the angle between the wind direction and the runway heading
            double windRelativeAngleDegrees = windDirectionDegrees - runwayHeadingDegrees;

            // Convert the relative angle to radians for trigonometric calculations
            double windRelativeAngleRadians = windRelativeAngleDegrees * (Math.PI / 180.0);

            // Calculate the crosswind component using the sine of the relative angle
            double crossWindComponent = windSpeedKnots * Math.Sin(windRelativeAngleRadians);

            // Round to the nearest whole number and return as an integer
            return (int)Math.Round(crossWindComponent);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;



            SolidBrush redBrush = new SolidBrush(Color.Red);

            int centerX = 250;
            int centerY = 320;
            int radius = 100;
            float scale = 1;

            Rectangle perimeter = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            //g.DrawEllipse(new Pen(redBrush), perimeter);
            //g.DrawRectangle(new Pen(redBrush), perimeter);

            drawCompassCard(g, centerX, centerY, radius);

            if (SelectedRunway > -1)
            {
                drawRunway(g, centerX, centerY, scale, SelectedRunway);
            }

            if (Weather is not null)
            {
                drawWindArrow(g, centerX, centerY, scale, (int)Weather.WindDirDegs);
            }








        }

        private void drawRunway(Graphics g, int centerX, int centerY, float scale, int selectedRunway)
        {
            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(selectedRunway * 10);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.FillRectangle(blackBrush, -20 * scale, -60 * scale, 40 * scale, 120 * scale);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            g.DrawString(SelectedRunway.ToString("00"), new Font(this.Font, FontStyle.Bold), new SolidBrush(Color.White), 0, 40 * scale, sf);
            g.ResetTransform();
        }

        private void drawWindArrow(Graphics g, int centerX, int centerY, float scale, int bearing)
        {
            Pen windPen = new Pen(Color.Red);


            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(bearing + 180);
            g.DrawPolygon(windPen,
                new PointF[] {
                    new(-(5*scale),  -(30*scale)),
                    new(-(5*scale),  +(50*scale)),
                    new(+(5*scale),  +(50*scale)),
                    new(+(5*scale),  -(30*scale)),
                    new(+(15*scale), -(30*scale)),
                    new(-(0*scale),  -(50*scale)),
                    new(-(15*scale), -(30*scale))
                }
            );
            g.ResetTransform();

        }

        private void drawCompassCard(Graphics g, int centerX, int centerY, int radius)
        {
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Far; //top


            g.DrawEllipse(pen, centerX - radius + 30, centerY - radius + 30, 2 * (radius - 30), 2 * (radius - 30));

            //g.DrawString("000", this.Font, brush, CenterX, CenterY - radius1, sf);
            g.TranslateTransform(centerX, centerY);

            int StepSize = 10;
            for (int i = 0; i < 360; i += StepSize)
            {
                if (i % 90 == 0)
                {
                    string cardinal = "";
                    SolidBrush cardinalBrush = new(Color.Black);

                    switch (i)
                    {
                        case 0:
                            cardinal = "N";
                            cardinalBrush.Color = Color.Red;
                            break;
                        case 90:
                            cardinal = "E";
                            break;
                        case 180:
                            cardinal = "S";
                            break;
                        case 270:
                            cardinal = "W";
                            break;
                    }
                    g.DrawString(cardinal, this.Font, cardinalBrush, 0, -radius + 15, sf);
                }
                if (i % 30 == 0)
                {
                    g.DrawString(i.ToString("000"), this.Font, blackBrush, 0, -radius + 30, sf);
                    g.DrawLine(pen, 0, -radius + 30, 0, -radius + 40);
                }
                else
                {
                    g.DrawLine(pen, 0, -radius + 30, 0, -radius + 35);
                }
                g.RotateTransform(StepSize);
            }
            g.ResetTransform();
        }

        private void RunwayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure sender is a RadioButton
            if (sender is RadioButton radioButton)
            {
                // Only handle the event if the radio button is checked
                if (radioButton.Checked)
                {
                    // Extract the numeric part from the radio button's name "rb01"
                    string numericPart = radioButton.Name.Substring(2); // Skip the "rb" prefix
                    if (int.TryParse(numericPart, out int selectedNumber))
                    {
                        SelectedRunway = selectedNumber;
                    }
                    else
                    {
                        SelectedRunway = -1;
                    }
                    this.Invalidate();
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
            startTimer();
            fetchData();
        }
    }

    // Define your data model class to deserialize JSON
    public class WeatherData
    {
        public WCoord Coord { get; set; }
        public WWeather[] Weather { get; set; }
        public WMain Main { get; set; }

        public WSys Sys { get; set; }

        public WWind Wind { get; set; }
        // Define other properties as needed

        public double TemperatureCelsius
        {
            get { return Math.Round(Main.Temp - 273.15); }
        }

        public double WindDirDegs
        {
            get { return (int)Math.Round(Wind.Deg / 10.0) * 10; }
        }

        public double WindSpeedKnots
        {
            get { return Math.Round(Wind.Speed * 1.94384); }
        }

        public double WindGustKnots
        {
            get { return Math.Round(Wind.Gust * 1.94384); }
        }

        public DateTime dateTime
        {
            get { return DateTimeOffset.FromUnixTimeSeconds((long)Dt).UtcDateTime; }
        }

        public DateTime Sunrise
        {
            get { return DateTimeOffset.FromUnixTimeSeconds((long)Sys.Sunrise).UtcDateTime; }
        }

        public DateTime Sunset
        {
            get { return DateTimeOffset.FromUnixTimeSeconds((long)Sys.Sunset).UtcDateTime; }
        }

        public class WCoord
        {
            public double Lon { get; set; }
            public double Lat { get; set; }
        }

        public class WWeather
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }



        public class WMain
        {
            public double Temp { get; set; }
            public double FeelsLike { get; set; }
            public double Pressure { get; set; }
            public double Humidity { get; set; }
            public double Sea_Level { get; set; }
            public double Ground_Level { get; set; }
            // Define other properties as needed
        }
        public double Visibility { get; set; }

        public class WWind
        {
            public double Speed { get; set; }
            public double Deg { get; set; }
            public double Gust { get; set; }
        }
        public double Dt { get; set; }

        public class WSys
        {
            public double Type { get; set; }
            public double Id { get; set; }
            public string Country { get; set; }
            public double Sunrise { get; set; }
            public double Sunset { get; set; }
        }
    }
}
