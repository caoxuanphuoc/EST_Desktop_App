using CodeBase.EntityFrameworkCore.Repositories;
using ESTDesktop.Core.Entities.TaskDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDesktop.EntityFrameworkCore.Repositories
{
    public interface ITaskWorkRepository : IBaseRepository<TaskToWork,long>
    {
    }
}
