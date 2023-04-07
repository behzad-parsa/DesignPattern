using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Exercise
{
    internal class Bicycle : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction-Bicycle");
            return 2;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA-Bicycle");
            return 2;
        }
    }
}
