using System;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GMarker.Persistence.Configurations;
using GMarker.UI.Factories;

namespace GMarker.UI
{
    /// <summary>
    /// Входная точка приложения.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                System.Windows.Forms.Application.Run(mainForm);
            }
        }

        /// <summary>
        /// Настройка сервисов в контейнере внедрения зависимостей.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        private static void ConfigureServices(ServiceCollection services)
        {
            var connectionString = ConfigurationManager
                .ConnectionStrings["DbConnection"]
                .ConnectionString;

            services.AddPersistence(connectionString);
            services.AddScoped<IUnitPresenterFactory, UnitPresenterFactory>();
            services.AddScoped<MainForm>();
        }
    }
}
