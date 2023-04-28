using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Exercise
{
    internal interface IEncrypt
    {
        string Encryption(string message);
    }
}
