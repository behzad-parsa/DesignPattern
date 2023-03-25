using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //My simple Code
            Editor editor = new Editor();
            editor.Content = "a";
            editor.Content = "b";
            editor.Content = "c";
            Console.WriteLine(editor.Content);
            editor.Undo();
            Console.WriteLine(editor.Content);
            editor.Undo();
            Console.WriteLine(editor.Content);

            Console.ReadLine();
        }
    }
}