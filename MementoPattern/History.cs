using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class History
    {
        public List<EditorState> EditorStateList { get; set; }
        public History() 
        {
            EditorStateList = new List<EditorState>();
        }

        public void Push (EditorState state)
        {
            EditorStateList.Add(state);
        }
        public EditorState Pop()
        {
            var index = EditorStateList.Count() - 1;
            var lastItem = EditorStateList[index];
            EditorStateList.RemoveAt(index);
            return lastItem;
        }
    }
}
