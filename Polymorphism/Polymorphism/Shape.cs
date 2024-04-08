using System.Security.Cryptography;

namespace MethodOverriding
{

    public class Circle : Shape
    {
        public override void Draw()//i encapsulate the concept of draw
        {
            /*//any code specific to the circle itself
            base.Draw();//->calls the method draw of shape.*/
            Console.WriteLine("Draw a circle");

        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    // since shape can have many forms, like  circle and rectangle
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //  public Position Position { get; set; }

        //method overriding need the keyword virtual, to override the method because the way we draw a circle and the erctangle is differente
        public virtual void Draw()
        {

        }
    }
}