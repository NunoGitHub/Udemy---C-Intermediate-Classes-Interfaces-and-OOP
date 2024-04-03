namespace Constructors
{
    public class Car : Vehicle
    {
        //using base to choose constructor
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized, " + registrationNumber);
        }
    }
}