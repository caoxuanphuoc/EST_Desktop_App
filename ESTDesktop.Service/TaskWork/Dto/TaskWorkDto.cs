using CodeBase.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDesktop.Service.TaskWork.Dto
{
    public class TaskWorkDto : EntityBase<long>
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public string TaskCode { get; set; }

        public string BranchInGit { get; set; }

        // text of StatusTask enum
        public string Status { get; set; }
    }
}
