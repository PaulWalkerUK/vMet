namespace vMet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Airport> airports = [];
            airports.Add(new Airport("EGCJ", "Sherburn-in-Elmet", 53.7929, -1.2241, 26,
            [
                new RunwayPair(new Runway("01", 10), new Runway("19", 190)),
                new RunwayPair(new Runway("06", 60), new Runway("24", 240)),
                new RunwayPair(new Runway("10", 100), new Runway("28", 280))
            ]));

            airports.Add(new Airport("EGEC", "Campbeltown", 55.43647, -5.68085, 42,
            [
                new RunwayPair(new Runway("11", 50), new Runway("29", 230))
            ]));

            airports.Add(new Airport("EGNL", "Walney Island"    , 54.1167, -3.2500, 44,
            [
                new RunwayPair(new Runway("05", 50), new Runway("23", 230)),
                new RunwayPair(new Runway("17", 170), new Runway("35", 350))
            ]));

            airports.Add(new Airport("EGPG", "Cumbernauld", 55.974870046280664, -3.9742469617112173, 348,
            [
                new RunwayPair(new Runway("07", 70), new Runway("25", 250))
            ]));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(airports));
            
            
        }
    }
}