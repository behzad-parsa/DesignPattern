using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Exercise
{
    internal class Drive : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction-Drive");
            return 1;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA-Drive");
            return 1;
        }
    }
}
