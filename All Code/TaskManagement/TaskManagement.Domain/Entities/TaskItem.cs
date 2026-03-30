using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
