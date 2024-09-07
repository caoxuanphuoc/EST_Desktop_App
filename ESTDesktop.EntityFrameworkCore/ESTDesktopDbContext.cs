using CodeBase.Core.Entities;
using ESTDesktop.Core.Entities.TaskDomain;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.EntityFrameworkCore
{
    public class CodebBaseDbContext : DbContext
    {

        public CodebBaseDbContext(DbContextOptions<CodebBaseDbContext> options)
             : base(options)
        {
        }

        // Define your DbSets (tables) here
        // public DbSet<YourEntity> YourEntities { get; set; }
        public DbSet<ExampleEntity> ExampleEntities { get; set; }
        public DbSet<TaskToWork> TaskToWorks { get; set; }
        public DbSet<TodoInTask> TodoInTasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure your entity mappings here
            // modelBuilder.Entity<YourEntity>().ToTable("YourTableName");
        }
    }
}
