namespace Testability
{
    public class OrderProcessor
	{
		private readonly IShippingCalculator _shippingCalculator;

        //no reference to the shippingCalculator, loose coupling
        //if we change CalculateShipping(), is not going to have any impact on our OrderProcessor class, this class doesnt know anything about the ShippingCalculator class, just knows there is a class that can fulfill that need
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

		public void Process(Order order)
		{
			if (order.isShipped)
				throw new InvalidOperationException("This order is already processed.");

			order.Shipment = new Shippment
			{
				Cost = _shippingCalculator.CalculateShipping(order),
				ShippingDate = DateTime.Today.AddDays(1)
			};
		}
    }
}