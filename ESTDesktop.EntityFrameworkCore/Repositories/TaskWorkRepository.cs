using CodeBase.EntityFrameworkCore;
using CodeBase.EntityFrameworkCore.Repositories;
using ESTDesktop.Core.Entities.TaskDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDesktop.EntityFrameworkCore.Repositories
{
    public class TaskWorkRepository : BaseRepository<TaskToWork, long>, ITaskWorkRepository
    {
        public TaskWorkRepository(CodebBaseDbContext context) : base(context)
        {
        }
    }
}
