namespace NorthWind.Sale.Controllers
{
    public class CreateOrderController: ICreateOrderController
    {

        private readonly ICreateOrderInputPort input;
        private readonly ICreateOrderPresenter presenter;

        public CreateOrderController(ICreateOrderInputPort _input, ICreateOrderPresenter _presenter)
        {
            input = _input;
            presenter = _presenter;
        }

       

        public async ValueTask<int> Handle(CreateOrderDTO orderDTO)
        {
            await input.Handle(orderDTO);
            return presenter.OrderId;
        }
    }
}

