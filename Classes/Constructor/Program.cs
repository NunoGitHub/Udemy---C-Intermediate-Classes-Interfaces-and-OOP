using Constructor;
using Methods;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "maria");
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);

            //OBJECT  initializer, initialize object without constructers
            Customer c = new Customer { Id = 1, Name = "Maria" };
            Console.WriteLine(c.Name);

            ParamsModifier modifier = new ParamsModifier();
            int f = modifier.Add(1, 2, 3, 4);
            Console.WriteLine("sum  = " + f);

            int a = 0;

            RefModifier refModifier = new RefModifier();
            refModifier.ChangeValRef(ref a);

            Console.WriteLine(a);

            try
            {
                Modifier.CallMethods();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("error in the function "+e.StackTrace);
            }

        }
    }
}