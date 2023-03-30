using MementoPattern.Exercise;
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
            //Course Code
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

            Console.WriteLine("\n\n Excersise \n\n");

            //------  Exercise Code  ----------------------------
            Document document = new Document();
            Exercise.History historyDoc = new Exercise.History();

            document.Content = "d";
            historyDoc.Push(document.CreateState());

            document.FontSize = 10;
            historyDoc.Push(document.CreateState());
            
            document.FontName = "Tahoma";
            Console.WriteLine(document);

            document.Restore(historyDoc.Pop());
            Console.WriteLine(document);
                        
            
            document.Restore(historyDoc.Pop());
            Console.WriteLine(document);


            Console.ReadLine();
        }
    }
}