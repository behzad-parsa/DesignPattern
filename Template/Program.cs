using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new TransferMoneyTask();
            task.Execute();

            Console.WriteLine("----\n");

            var taskReport = new GenerateReportTask();
            taskReport.Execute();

            Console.ReadLine();
        }
    }
}
