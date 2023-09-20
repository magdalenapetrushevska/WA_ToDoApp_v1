using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Evaluation;
using Project = WA_ToDoApp_v1.Models.DomainModels.Project;

namespace WA_ToDoApp_v1.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public String? Name { get; set; }
        public ICollection<Project>? Projects { get; set; }
    }
}
