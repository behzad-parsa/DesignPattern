using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Exercise
{
    internal class AESAlgorithm : IEncrypt
    {
        public string Encryption(string message)
        {
            Console.WriteLine($"AES Encryption Applied to [{message}]");
            return "EncryptedText";
        }
    }
}
