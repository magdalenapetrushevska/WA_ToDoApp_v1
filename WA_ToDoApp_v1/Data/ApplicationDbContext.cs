using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.Xml;
using WA_ToDoApp_v1.Models.DomainModels;
using WA_ToDoApp_v1.Models.Identity;
using Task = WA_ToDoApp_v1.Models.DomainModels.Task;

namespace WA_ToDoApp_v1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Task>()
                .HasOne(z => z.Project)
                .WithMany(z => z.Tasks)
                .HasForeignKey(z => z.ProjectId);

            builder.Entity<Project>()
                .HasOne(z => z.User)
                .WithMany(z => z.Projects)
                .HasForeignKey(z => z.UserId);

        }
    }
}