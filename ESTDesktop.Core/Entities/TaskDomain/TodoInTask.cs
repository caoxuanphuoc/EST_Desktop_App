using CodeBase.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDesktop.Core.Entities.TaskDomain
{
    public class TodoInTask : EntityAuditBase<long>
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public float MinTime { get; set; }
        public float OpTime { get; set; }
        public float MaxTime { get; set; }
        public float EstTime { get; set; }
        public float ActualTime { get; set; }

        // is Text of SubTaskEnum
        public string Status { get; set; }
    }
}
