using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CodeBase.EntityFrameworkCore
{
    public class CodebBaseDbContextFactory : IDesignTimeDbContextFactory<CodebBaseDbContext>
    {
        public CodebBaseDbContext CreateDbContext(string[] args)
        {
            // Build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configure DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<CodebBaseDbContext>();
            optionsBuilder.UseSqlite(connectionString);

            return new CodebBaseDbContext(optionsBuilder.Options);
        }
    }
}
