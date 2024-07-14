using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vMet
{
    public class Runway
    {
        public Runway(string name, int heading) { 
            this.Name = name;
            this.Heading = heading;
        }

        public string Name { get; }
        public int Heading { get; }
    }
}
