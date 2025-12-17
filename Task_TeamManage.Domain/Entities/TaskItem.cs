using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_TeamManage.Domain.Entities
{
    public class TaskItem:BaseModel
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public string Title { get; set; }
        public string? Description { get; set; }
        public TaskStatus Status { get; set; }
        public Guid? AssignedToUserId { get; set; }  // FK to AspNetUsers.Id
        public Guid CreatedByUserId { get; set; }
        public Guid TeamId { get; set; }
        public DateTime? DueDate { get; set; }
        
    }
}
