using CSharp;

namespace Constructor
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<order> orders;

        public Customer()
        {
            orders = new List<order>();
        }
        //  public Customer(int id) : this() ->  ": this()" uses the first contructor to
        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}