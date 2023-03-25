using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Editor
    {
        // My SImple Code
        private string content;
        private readonly Stack<string> stack;
        
        public string Content { 
            get
            {
                return content;
            }
            set
            {
                stack.Push(value);
                content = stack.Peek();
            }
        }


        public Editor()
        {
            stack = new Stack<string>();
        }

        public void Undo()
        {
            stack.Pop();
            content = stack.Peek();
        }
    }
}
