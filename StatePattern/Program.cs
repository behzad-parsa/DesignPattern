using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();
            
            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();


            Console.ReadLine();
        }
    }
}
