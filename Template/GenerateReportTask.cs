using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class GenerateReportTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generating Report ...");
        }
    }
}
