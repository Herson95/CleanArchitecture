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
            OrderAggregate order = OrderAggregate.From(orderDTO);
            await repository.CreateOrder(order);
            await repository.SaveChanges();
            await outputPort.Handle(order.Id);
        }
    }
}

