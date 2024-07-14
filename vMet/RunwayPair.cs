using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vMet
{
    public class RunwayPair
    {
        private Runway[] runways = new Runway[2];

        public Runway[] Runways { get { return runways; } }

        public RunwayPair(Runway runwayA, Runway runwayB) {
            runways[0] = runwayA;
            runways[1] = runwayB;
        }
    }
}
