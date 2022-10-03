namespace NorthWind.Sale.BusinessObjects.Interfaces.Ports
{
    public interface ICreateOrderOutputPort
    {
        ValueTask Handle(int orderId);
    }
}

