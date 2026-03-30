using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Application.DTOs;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskService
    {
        Task<List<TaskDto>> GetTasks();

        Task<TaskDto> GetTask(int id);

        Task CreateTask(TaskDto dto);
    }
}
