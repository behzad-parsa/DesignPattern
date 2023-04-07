using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Exercise
{
    internal class DirectionService
    {
        public ITravelMode TravelMode { get; set; }

        public DirectionService(ITravelMode travelMode)
        {
            this.TravelMode = travelMode;
        }

        public object GetDirection()
        {
            return TravelMode.GetDirection();
        }

        public object GetEta()
        {
            return TravelMode.GetEta();
        }

    }
}
