using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class BrowseHistory
    {
        private List<string> urls = new List<string>();
        // can change this to array and implement the structure based on the array without affecting the iterator code 
        //private string[] urls = new string[10]; 

        public void Push(string url)
        {
            urls.Add(url);

        }
        public string Pop()
        {
            var lastElement = urls[urls.Count - 1];
            urls.Remove(lastElement);
            return lastElement;
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator
        {
            private BrowseHistory browseHistory;
            private int index;
            public ListIterator(BrowseHistory history)
            {
                this.browseHistory = history;
            }
            public string Current()
            {
                return browseHistory.urls[index];
            }

            public bool HasNext()
            {
                return index < browseHistory.urls.Count();
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
