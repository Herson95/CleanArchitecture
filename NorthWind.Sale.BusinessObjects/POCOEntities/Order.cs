namespace NorthWind.Sale.BusinessObjects.POCOEntities
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipCountry { get; set; }

        public string ShipPostalCode { get; set; }

        public ShippingType ShippingType { get; set; } = ShippingType.Road;

        public DiscountType discountType { get; set; } = DiscountType.Percentage;

        public decimal Discount { get; set; } = 10;

        public DateTime DateTime { get; set; } = DateTime.UtcNow;
    }
}

