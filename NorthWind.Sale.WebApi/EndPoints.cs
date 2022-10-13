namespace NorthWind.Sale.WebApi;

public static class EndPoints
{
    public static WebApplication NorthWindSaleEndPoints(this WebApplication app)
    {
        app.MapPost("/create",async (CreateOrderDTO order,ICreateOrderController controller)
            => Results.Ok(await controller.CreateOrder(order)));

        return app;
    }
}


