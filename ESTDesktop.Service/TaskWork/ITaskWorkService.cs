using ESTDesktop.Service.TaskWork.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDesktop.Service.TaskWork
{
    public interface ITaskWorkService
    {

        Task<TaskWorkDto> CreateTaskWorkAsync(TaskWorkDto taskWorkDto);

        // Lấy thông tin của một TaskWork theo ID
        Task<TaskWorkDto> GetTaskWorkByIdAsync(long id);

        // Cập nhật thông tin của một TaskWork
        Task<TaskWorkDto> UpdateTaskWorkAsync(TaskWorkDto taskWorkDto);

        // Xóa một TaskWork theo ID
        Task<bool> DeleteTaskWorkAsync(long id);
    }
}
