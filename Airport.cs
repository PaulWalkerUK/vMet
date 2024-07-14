using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vMet
{
    public class Airport
    {
        public Airport(string icao, string name, double latitude, double longitude, int elevation, List<RunwayPair> runwayPairs)
        {
            this.Icao = icao;
            this.Name = name;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Elevation = elevation;
            this.RunwayPairs = runwayPairs;
        }

        public string Icao { get; }
        public string Name { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public int Elevation { get; }
        internal List<RunwayPair> RunwayPairs { get; }

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
