using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace vMet
{
    internal class AirportConfigLoader
    {
        private readonly string _filepath;

        public AirportConfigLoader()
        {
            _filepath = Path.Combine(Path.Combine(AppContext.BaseDirectory,"Resources"), "airports.json");
        }

        public List<Airport> LoadAirports()
        {
            string json = File.ReadAllText(_filepath);
            var airports = JsonSerializer.Deserialize<List<Airport>>(json);
            return airports ?? new List<Airport>();
        }
    }
}
