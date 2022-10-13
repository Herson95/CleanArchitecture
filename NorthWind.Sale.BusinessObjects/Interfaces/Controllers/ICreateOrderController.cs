namespace NorthWind.Sale.BusinessObjects.Interfaces.Controllers
{
    public interface ICreateOrderController
    {
        ValueTask<int> CreateOrder(CreateOrderDTO orderDTO);
    }
}

