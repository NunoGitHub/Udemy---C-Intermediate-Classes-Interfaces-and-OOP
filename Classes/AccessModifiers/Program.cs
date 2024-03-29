namespace AccessModifiers
{
    class Program
    {
        public class Person
        {
            //encapsulation
            private DateTime _birthDate;
            public void SetBirthDate(DateTime birthDate)
            {
                this._birthDate = birthDate;
            }
            public DateTime GetBirthDate()
            {
                return _birthDate;
            }
        }
        public static void Main(string[] args)
        {
            var person = new Person();
            //whats the difference of accessing directly from the variable
            //the difference is that obejcts is about behaviour, about what they do, their
            //fields is primarily their internals, their implementation detail, which should be hidden from the outside world
            //so objects should hide their implementation detail and reveal what they can do
            //as opposed  to how they do what they are supposed to do.
            person.SetBirthDate(new DateTime(1996, 1, 1));
            Console.WriteLine(person.GetBirthDate().ToString());
        }
    }
}