using DataLayer.Implementations;
using DataLayer;
using DataLayer.Contracts;
using DataLayer.Models;
using Microsoft.Extensions.DependencyInjection;

namespace WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();
                var form1 = serviceProvider.GetRequiredService<frmMain>();
                Application.Run(form1);
            }
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.

            //Application.Run(new frmMain());
        }


        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>()
                    .AddScoped<IGenericRepository<Contact>, EfGenericRepository<Contact>>()
                    .AddScoped<IGenericRepository<Accounting>, EfGenericRepository<Accounting>>()
                    .AddScoped<IGenericRepository<MyProfile>, EfGenericRepository<MyProfile>>()
                    .AddScoped<IContactRepository, ContactRepository>()
                    .AddScoped<IUnitOfWork,UnitOfWork>()
                    .AddScoped<frmMain>()
                    .AddTransient<frmContacts>()
                    .AddTransient<FormAddContact>()
                    .AddTransient<FormUpdateContact>()
                    .AddTransient<FormAccounting>()
                    .AddTransient<FormNewTransaction>()
                    .AddScoped<frmProfile>();
        }
    }
}