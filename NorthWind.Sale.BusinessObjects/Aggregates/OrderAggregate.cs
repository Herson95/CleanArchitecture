namespace NorthWind.Sale.BusinessObjects.Aggregates
{
    public class OrderAggregate : Order
    {
        private readonly List<OrderDetail> orderDetails = new();

        public IReadOnlyCollection<OrderDetail> OrderDetails => orderDetails;

        private void AddDetail(OrderDetail detail)
        {
            var exist = orderDetails.FirstOrDefault(x=>x.ProductId == detail.ProductId);

            if (exist != default)
            {
                orderDetails.Add(exist with
                {
                    Quantity = (short)(detail.Quantity + exist.Quantity)
                });

                orderDetails.Remove(exist);
            }
            else
            {
                orderDetails.Add(detail);
            }
        }

        public void AddDetail(int productId, decimal unitPrice, short quantity) =>
            AddDetail(new OrderDetail(productId,unitPrice,quantity));

        public static OrderAggregate From(CreateOrderDTO orderDTO)
        {
            OrderAggregate order = new()
            {
                CustomerId = orderDTO.CustomerId,
                ShipAddress = orderDTO.ShipAddress,
                ShipCity = orderDTO.ShipCity,
                ShipCountry = orderDTO.ShipCountry,
                ShipPostalCode = orderDTO.ShipPostalCode
            };

            foreach (CreateOrderDetailDTO item in orderDTO.OrderDetails)
            {
                order.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
            }

            return order;
        }
    }
}

