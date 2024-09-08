using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDesktop.AppView.TaskView.TaskViewControl.Dtos
{
    public class TaskDetailDto
    {
        public int No { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public float MinTime { get; set; }
        public float Est { get; set; }
        public float MaxTime { get; set; }
        public TimeSpan TimeWork { get; set; }

        public bool IsRunning { get; set; }
    }
}
