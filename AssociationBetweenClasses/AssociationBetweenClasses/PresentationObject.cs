namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboartd");
        }
        public void Dupicate()
        {
            Console.WriteLine("Object was duplicated");
        }


    }
}