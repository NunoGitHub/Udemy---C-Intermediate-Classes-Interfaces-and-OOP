namespace MethodOverriding
{

    public class Program
    {
        static void Main(string[] args)
        {
            var shapes =  new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}