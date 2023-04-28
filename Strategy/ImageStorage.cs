using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //context class
    internal class ImageStorage
    {
        //Model 1
        //can implement this way and using constructor 

        //private readonly ICompressor compressor;
        //private readonly IFilter filter;
        //public ImageStorage(ICompressor compressor, IFilter filter)
        //{
        //    this.compressor = compressor;
        //    this.filter = filter;
        //}

        //public void Store(string fileName)
        //{
        //    compressor.Compress(fileName);
        //    filter.Apply(fileName);
        //}

        //Model 2
        //or this way and just use methods 
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}
