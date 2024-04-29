namespace Testability
{
    class Program
	{
		static void Main(string[] args)
		{
			//in the main needs a concrete class, beacause is like a matchmaker ,
			//it knows different concrete types and ties them together 
			var orderProcessor = new OrderProcessor(new ShippingCalculator());
			var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
			orderProcessor.Process(order);
		}
	}
}