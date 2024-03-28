
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
          //better code
          Move(newLocation.x, newLocation.y);

        }
    }

    public class Modifier
    {
        public static void CallMethods()
        {
            Console.WriteLine("Methods overloading");
            Point point = new Point(10, 5);
            point.Move(new Point(40, 60));
            Console.WriteLine($"Point at ({point.x}, {point.y})");
            point.Move(100, 200);
            Console.WriteLine($"Point at ({point.x}, {point.y})");
        }

    }
}
