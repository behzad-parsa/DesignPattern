using StatePattern.Exercise;
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

            Console.WriteLine("\n ---------------------------- \n");
            //Exercise
            var directionService = new DirectionService();
            directionService.TravelMode = new Drive();
            directionService.GetDirection();
            directionService.GetEta();

            directionService.TravelMode = new Walk();
            directionService.GetDirection();
            directionService.GetEta();

            Console.ReadLine();
        }
    }
}
