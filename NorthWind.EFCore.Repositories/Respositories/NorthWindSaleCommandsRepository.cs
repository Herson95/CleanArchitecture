namespace NorthWind.EFCore.Repositories.Respositories
{
    public class NorthWindSaleCommandsRepository : INorthWindSaleCommandsRepository
    {
        private readonly NorthWindSaleContext context;

        public NorthWindSaleCommandsRepository(NorthWindSaleContext _context)
        {
            context = _context;
        }

        public async ValueTask CreateOrder(OrderAggregate order)
        {
            await context.AddAsync(order);
            await context.AddRangeAsync(order.OrderDetails.Select(detail => new OrderDetail()
            {
                Order = order,
                ProductId = detail.ProductId,
                UnitPrice = detail.UnitPrice,
                Quantity = detail.Quantity
            }));
        }

        public async ValueTask SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}

