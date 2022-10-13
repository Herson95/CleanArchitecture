namespace NorthWind.Sale.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindSaleControllers(this IServiceCollection services)
    {
        services.AddScoped<ICreateOrderController, CreateOrderController>();
       
        return services;
    }
}

