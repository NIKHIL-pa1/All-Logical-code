using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Application.DTOs;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TaskDto>> GetTasks()
        {
            var tasks = await _repository.GetAllTasks();

            return tasks.Select(x => new TaskDto
            {
                Title = x.Title,
                Description = x.Description
            }).ToList();
        }
        public async Task<TaskDto> GetTask(int id)
        {
            var task = await _repository.GetTaskById(id);

            return new TaskDto
            {
                Title = task.Title,
                Description = task.Description
            };
        }

        public async Task CreateTask(TaskDto dto)
        {
            var task = new TaskItem
            {
                Title = dto.Title,
                Description = dto.Description,
                CreatedDate = DateTime.Now
            };

            await _repository.AddTask(task);
        }
    }
}
