namespace NorthWind.Sale.BusinessObjects.Interfaces.Repositories
{
    public interface INorthWindSaleCommandsRepository : IUnitOfWork
    {
        ValueTask CreateOrder(OrderAggregate order);
    }
}

