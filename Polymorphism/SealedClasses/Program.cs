namespace SealedClasses
{

    /* public class Circle: Shape // circle cannot derive from shape because is sealed
     {
         public override void Draw()
         {
             Console.WriteLine("Draw circle");
         }
     }*/

    public class Circle : Shape
    {
        public override sealed void Draw()
        {
            Console.WriteLine("Draw circle");
        }

    }


    public class Circle2 : Circle
    {
       /* public override void Draw() //cant override inherited method Draw because is sealed
        {
            Console.WriteLine("draw circle 2");
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle();
            c.Draw();
            var c2 = new Circle2();
            c2.Draw();
        }
    }
}