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
            History history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";

            //Console.WriteLine(editor.Content);
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            Console.ReadLine();
        }
    }
}