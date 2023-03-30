using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Exercise
{
    internal class History
    {
        private readonly List<DocumentState> documentStatesList;

        public History()
        {
            documentStatesList = new List<DocumentState>();
        }


        public void Push(DocumentState state)
        {
            documentStatesList.Add(state);
        }

        public DocumentState Pop()
        {
            var lastItem = documentStatesList.Last();
            documentStatesList.Remove(lastItem);
            return lastItem;
        }
    }
}
