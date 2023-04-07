using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Exercise
{
    internal class Walk : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction-Walk");
            return 4;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA-Walk");
            return 4;
        }
    }
}
