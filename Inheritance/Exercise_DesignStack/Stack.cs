namespace Stack
{
    class Stack
    {
        private List<object> _stack = new List<object>();//lifo
        public void Push(Object obj)
        {
            if (obj == null) throw new InvalidOperationException("Cannot push null data");
            _stack.Insert(0, obj);
        }

        public Object Pop()
        {
            if (_stack.Count == 0) throw new InvalidOperationException("stack is empty");
            //value to be removed, just to print in the main 
            var aux = _stack[0];
            _stack.RemoveAt(0);
            return aux;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}