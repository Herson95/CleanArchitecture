namespace NorthWind.Sale.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSaleServices(this IServiceCollection services,
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

