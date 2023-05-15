using Microsoft.Extensions.DependencyInjection;
using GMarker.Application.Interfaces;
using GMarker.Persistence.Repositories;

namespace GMarker.Persistence.Configurations
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Регистрирует зависимость для интерфейса IUnitRepository и его реализации UnitRepository, используя указанную строку соединения с базой данных.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        /// <param name="connectionString">Строка соединения с базой данных.</param>
        /// <returns>Коллекция сервисов, с зарегистрированной зависимостью для IUnitRepository и UnitRepository.</returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString) =>
            services.AddScoped<IUnitRepository, UnitRepository>(sp => new UnitRepository(connectionString));
    }
}
