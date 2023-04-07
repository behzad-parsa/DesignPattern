using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw Dash Rectangle");
        }
    }
}
