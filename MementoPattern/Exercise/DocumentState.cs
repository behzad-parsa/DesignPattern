using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Exercise
{
    internal class DocumentState
    {
        public string Content { get; private set; }
        public string FontName { get; private set; }
        public int FontSize { get; private set; }

        public DocumentState(string content, string fontName, int fontSize)
        {
            this.Content = content;
            this.FontName = fontName;   
            this.FontSize = fontSize;
        }
    }
}
