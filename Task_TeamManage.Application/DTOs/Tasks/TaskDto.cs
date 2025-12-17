using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_TeamManage.Application.DTOs.Tasks
{
    public class TaskDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public TaskStatus Status { get; set; }
        public Guid TeamId { get; set; }
        public string? AssignedToUserId { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
