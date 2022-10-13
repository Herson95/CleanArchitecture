namespace NorthWind.Sale.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUsesCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateOrderInputPort, CreateOrderInteractor>();

        return services;
    }

}


