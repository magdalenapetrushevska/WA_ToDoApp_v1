using System;
using WA_ToDoApp_v1.Models.Identity;

namespace WA_ToDoApp_v1.Models.DomainModels
{
    public class Project : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public ICollection<Task>? Tasks { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
