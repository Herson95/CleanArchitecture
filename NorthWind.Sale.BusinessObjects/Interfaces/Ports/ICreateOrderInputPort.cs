namespace NorthWind.Sale.BusinessObjects.Interfaces.Ports
{
    public interface ICreateOrderInputPort
    {
        ValueTask Handle(CreateOrderDTO orderDTO);
    }
}

