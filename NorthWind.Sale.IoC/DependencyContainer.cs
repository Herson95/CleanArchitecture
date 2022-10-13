namespace NorthWind.Sale.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services,
            IConfiguration configuration,
            string connectionName)
        {
            services.AddRepositories(configuration,connectionName);
            services.AddUsesCasesServices();
            services.AddPresenters();
            services.AddNorthWindSaleControllers();

            return services;
        }


    }
}

