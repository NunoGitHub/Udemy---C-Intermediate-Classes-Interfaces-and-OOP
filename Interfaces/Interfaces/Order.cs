namespace Testability
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public Shippment Shipment { get; set; }
        public DateTime DatePlaced { get; set; }

        public bool isShipped
        {
            get { return Shipment != null; } 
        }


    }
}
