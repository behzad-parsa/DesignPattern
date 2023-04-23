using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal interface IIterator
    {
        bool HasNext();
        string Current(); //it can be T to be generic
        void Next();

    }
}
