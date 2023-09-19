using System.ComponentModel.DataAnnotations;
using WA_ToDoApp_v1.Models.Enums;

namespace WA_ToDoApp_v1.Models.DomainModels
{
    public class Task : BaseEntity
    {
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Display(Name = "Due date")]
        public DateTime? DueDate { get; set; }
        public Priority? MyProperty { get; set; }
        public Guid? ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
