namespace Casting
{
    class Program
    {
        public static void Main(string[] args, StreamReader a)
        {
            //Upcasting
            Text text = new Text();
            //this are pointing to the same object in memory, so they are both references to the same object in memory, but with differente views
            //the shape var have more limited properties
            //same reference diferente views
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            //it will be 100 because they have the same reference
            Console.WriteLine(text.Width);

            
            StreamReader reader = new StreamReader(new MemoryStream());

            //downcasting

            //you cant access properties defined in the Text object, so to access we need to downcast shape2
            Shape shape2 =  new Text();
            Text text1 = (Text)shape2;//now we have access to every property

        }
    }
}