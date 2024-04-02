using Amazon;

namespace AccessModifiers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var customer_ = new Customer_();
            customer_.Promote();

            var customer =  new Customer();
            //cannot do this because the access modifier is internal, only accessible in the same library
           // var rate = new Amazon.RateCalculator();
        }
    }
}