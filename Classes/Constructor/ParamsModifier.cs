

namespace Constructor
{
    public class ParamsModifier
    {
        public ParamsModifier(){}

        public int Add( params int[] numbers)
        {
            int f = 0;
            foreach (var n in numbers)
            {
                f += n;
            }
            return f;
        }
    }
}
