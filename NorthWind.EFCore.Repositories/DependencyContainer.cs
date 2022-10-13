namespace NorthWind.EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services,
            IConfiguration configuration,
            string connectionName)
        {
            services.AddDbContext<NorthWindSaleContext>(options => options.UseSqlServer(configuration.GetConnectionString(connectionName)));

            services.AddScoped<INorthWindSaleCommandsRepository, NorthWindSaleCommandsRepository>();

            return services;
        }


    }
}

