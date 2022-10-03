using NorthWind.Sale.BusinessObjects.Aggregates;

namespace NorthWind.Sale.UseCases.CreateOrder
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        private readonly ICreateOrderOutputPort outputPort;
        private readonly INorthWindSaleCommandsRepository repository;

        public CreateOrderInteractor(ICreateOrderOutputPort _outputPort,INorthWindSaleCommandsRepository _repository) 
        {
            outputPort = _outputPort;
            repository = _repository;
        }
        

        public async ValueTask Handle(CreateOrderDTO orderDTO)
        {
            OrderAggregate order = new()
            {
                CustomerId = orderDTO.CustomerId,
                ShipAddress = orderDTO.ShipAddress,
                ShipCity = orderDTO.ShipCity,
                ShipCountry = orderDTO.ShipCountry,
                ShipPostalCode = orderDTO.ShipPostalCode
            };

            foreach (var item in orderDTO.OrderDetails)
            {
                order.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
            }

            await repository.CreateOrder(order);
            await repository.SaveChanges();
            await outputPort.Handle(order.Id);
        }
    }
}

