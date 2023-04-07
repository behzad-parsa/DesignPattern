using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Exercise
{
    internal class Transit : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction-Transit");
            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA-Transit");
            return 3;
        }
    }
}
