using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllTasks();

        Task<TaskItem> GetTaskById(int id);

        Task AddTask(TaskItem task);

        Task UpdateTask(TaskItem task);

        Task DeleteTask(int id);
    }
}
