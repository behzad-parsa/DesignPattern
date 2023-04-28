using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing File [{fileName}] using JPEG");
        }
    }
}
