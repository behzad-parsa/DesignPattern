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
        
        public string Content { 
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }


        public Editor()
        {
        
        }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }
        public void Restore(EditorState editorState)
        {
            this.content = editorState.Content; 
        }

    }
}
