using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Task
    {
        private readonly AuditTrail auditTrail;
        public Task()
        {
            auditTrail = new AuditTrail();
        }
        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }
         
        protected abstract void DoExecute();
    }
}
