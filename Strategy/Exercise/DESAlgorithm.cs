using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Exercise
{
    internal class DESAlgorithm : IEncrypt
    {
        public string Encryption(string message)
        {
            Console.WriteLine($"DES Encryption Applied ... to [{message}]");
            return "Encrypted";
        }
    }
}
