
namespace Methods
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //overload
        public void Move(Point newLocation)
        {
            /*  this.x = newLocation.x;
              this.y = newLocation.y;*/
            //better code, defensive programing
            try
            {
                Move(newLocation.x, newLocation.y);
            }
            catch (Exception)
            {
                throw;
            }
            /*or 
             if(newLocation == null){
            throw new ArgumentNullexception("newLocation");
            }
             */
        }
    }


    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int nunber in numbers)
            {
                sum += nunber;
            }
            return sum;
        }

        public Calculator()
        {

        }

    }

    public class Modifier
    {
        public static void CallMethods()
        {
            try
            {
                UsePoints();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                UseParams();
                Console.WriteLine();
                int number;
                //try parse does not throw an exception , returns a boolean
                bool result = int.TryParse("abcc", out number);
                if (result)
                {
                    Console.WriteLine(number+"\n");
                }
                else
                {
                    Console.WriteLine("conversion failded");
                }
            }


        }

        public static void UsePoints()
        {

            Console.WriteLine("Methods overloading");
            Point point = new Point(10, 5);
            point.Move(new Point(40, 60));
            Console.WriteLine($"Point at ({point.x}, {point.y})");
            point.Move(100, 200);
            Console.WriteLine($"Point at ({point.x}, {point.y})");
            //testing null with try catch
            point.Move(null);
        }

        public static void UseParams()
        {
            Console.WriteLine("calculator");
            Calculator cal = new Calculator();
            Console.WriteLine("sum = " + cal.Add(1, 2));
            Console.WriteLine("sum = " + cal.Add(1, 2, 3, 4));
            Console.WriteLine("sum = " + cal.Add(new int[] { 1, 2, }));
        }

    }
}
