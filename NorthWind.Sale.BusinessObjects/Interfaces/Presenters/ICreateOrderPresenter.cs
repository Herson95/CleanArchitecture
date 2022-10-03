namespace NorthWind.Sale.BusinessObjects.Interfaces.Presenters
{
    public interface ICreateOrderPresenter : ICreateOrderOutputPort
    {
        int OrderId { get; }
    }
}

