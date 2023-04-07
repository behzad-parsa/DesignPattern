using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Exercise
{
    internal interface ITravelMode
    {
        object GetEta();
        object GetDirection();
    }
}
