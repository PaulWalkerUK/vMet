namespace vMet
{
    public class Airport
    {
        public string Icao { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Elevation { get; set; }
        public List<List<Runway>> RunwayPairs { get; set; }

        public string FullIcaoName {
            get
            {
                // Check if both Icao and Name are available
                if (!string.IsNullOrEmpty(Icao) && !string.IsNullOrEmpty(Name))
                {
                    return $"{Icao} - {Name}";
                }
                // Return Icao if Name is not available
                else if (!string.IsNullOrEmpty(Icao))
                {
                    return Icao;
                }
                // Return Name if Icao is not available
                else if (!string.IsNullOrEmpty(Name))
                {
                    return Name;
                }
                // Return an empty string if neither is available
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
