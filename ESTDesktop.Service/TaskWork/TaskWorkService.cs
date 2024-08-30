using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ESTDesktop.Service.TaskWork.Dto;

namespace ESTDesktop.Service.TaskWork
{
    public class TaskWorkService : ITaskWorkService
    {
        private readonly List<TaskWorkDto> _taskWorks = new List<TaskWorkDto>();
        private long _nextId = 1;

        public async Task<TaskWorkDto> CreateTaskWorkAsync(TaskWorkDto taskWorkDto)
        {
            taskWorkDto.Id = _nextId++;
            _taskWorks.Add(taskWorkDto);
            return await Task.FromResult(taskWorkDto);
        }

        public async Task<TaskWorkDto> GetTaskWorkByIdAsync(long id)
        {
            var taskWork = _taskWorks.Find(t => t.Id == id);
            return await Task.FromResult(taskWork);
        }

        public async Task<TaskWorkDto> UpdateTaskWorkAsync(TaskWorkDto taskWorkDto)
        {
            var existingTaskWork = _taskWorks.Find(t => t.Id == taskWorkDto.Id);
            if (existingTaskWork != null)
            {
                existingTaskWork.Title = taskWorkDto.Title;
                existingTaskWork.Description = taskWorkDto.Description;
                existingTaskWork.TaskCode = taskWorkDto.TaskCode;
                existingTaskWork.BranchInGit = taskWorkDto.BranchInGit;
                existingTaskWork.Status = taskWorkDto.Status;
            }
            return await Task.FromResult(existingTaskWork);
        }

        public async Task<bool> DeleteTaskWorkAsync(long id)
        {
            var taskWork = _taskWorks.Find(t => t.Id == id);
            if (taskWork != null)
            {
                _taskWorks.Remove(taskWork);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }
    }
}
