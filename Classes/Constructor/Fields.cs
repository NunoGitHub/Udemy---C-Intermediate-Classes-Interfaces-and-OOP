namespace Fields_
{
    class Customer_
    {
        public int Id;
        public string Name;
        //readonly stops redeclarations which prevents resetting the variavle, we only can initialize in constructor or in the creation of the variable
        public readonly List<order> orders = new List<order>();

        public Customer_()
        {
            
        }
        public Customer_(int id)
        {
            this.Id = id;
        }

        public Customer_(int id, string name): this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            orders.Add(new order ());
        }
    }

    class Fields
    {
        public Fields() { }
        public static void CallFields()
        {
            Customer_ customer = new Customer_();
            customer.Promote();

        }
    }
}
