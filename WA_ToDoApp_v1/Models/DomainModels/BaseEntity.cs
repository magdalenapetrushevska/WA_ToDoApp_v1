using System.ComponentModel.DataAnnotations;

namespace WA_ToDoApp_v1.Models.DomainModels
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
