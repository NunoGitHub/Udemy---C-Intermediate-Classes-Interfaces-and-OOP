

namespace AccessModifiers
{

    public class Person
    {
        //auto implemented properties, with private BirthDate can only be declared in the constructor
        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

    }
    public class Properties
    {
        public static void CallProperties()
        {
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine("age \n" + person.Age);
        }
    }
}
