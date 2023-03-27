using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class EditorState
    {
        public string Content { get; private set; }

        public EditorState(string content)
        {
            Content = content;
        }


    }
}
