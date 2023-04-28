using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Exercise
{
    internal class ChatClient
    {
        private readonly IEncrypt encrypt;

        public ChatClient(IEncrypt encrypt)
        {
            this.encrypt = encrypt;
        }

        public void Send(string message)
        {
            encrypt.Encryption(message);
            Console.WriteLine($"Sending The Encrypted Message .... ");
        }
    }
}
