using System.Collections;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Nuno");//this is a reference the string so boxing isnt going to happen
            list.Add(DateTime.Now);

            var otherList = new List<int>();//type safe and no boxing
            otherList.Add(1);


        }
    }
}