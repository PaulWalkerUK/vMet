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
            UserConfigMgr userConfigMgr = new UserConfigMgr();

            AirportConfigLoader airportLoader = new AirportConfigLoader();
            List<Airport> airports = airportLoader.LoadAirports();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(userConfigMgr, airports));
            
            
        }
    }
}