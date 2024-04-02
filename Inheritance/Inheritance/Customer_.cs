namespace AccessModifiers
{
    public class Customer_
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Promote Level 1");
            else
                Console.WriteLine("Promote Level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}