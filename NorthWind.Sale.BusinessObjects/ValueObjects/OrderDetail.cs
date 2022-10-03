namespace NorthWind.Sale.BusinessObjects.ValueObjects
{
    //Values object inmutables
    public record struct OrderDetail(int ProductId,decimal UnitPrice,short Quantity);
  
}

