using CodeBase.EntityFrameworkCore.Repositories.UnitOfWork;
using CodeBase.EntityFrameworkCore;
using ESTDesktop.AppView.Layout;
using ESTDesktop.AppView.TaskView;
using ESTDesktop.EntityFrameworkCore.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ESTDesktop.AppForm
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            // Resolve the main form and run the application
            var mainForm = ServiceProvider.GetRequiredService<TaskForm1>();
            Application.Run(mainForm);


        }


        private static void ConfigureServices(IServiceCollection services)
        {
            // Register DbContext
            services.AddDbContext<CodebBaseDbContext>(options =>
                options.UseSqlite("YourConnectionStringHere"));

            // Register repositories
            services.AddScoped<ITaskWorkRepository, TaskWorkRepository>();
            services.AddScoped<IUnitOfWork, EFUnitOfWork>();

            // Register forms
            services.AddTransient<LayoutForm>();
            services.AddTransient<TaskForm1>();
        }
    }
}