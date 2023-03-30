using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Exercise
{
    internal class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }


        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState documentState)
        {
            this.Content = documentState.Content;
            this.FontName = documentState.FontName;
            this.FontSize = documentState.FontSize;
        }

        public override string ToString()
        {
            return "Object Info :"
                + "\n\t" + "Content : " + Content
                + "\n\t" + "FontName : " + FontName
                + "\n\t" + "FontSize : " + FontSize+"\n";
        }
    }
}
