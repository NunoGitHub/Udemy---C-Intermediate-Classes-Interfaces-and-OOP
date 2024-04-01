namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _start;
        private bool runnig = false;
        private DateTime _end;
        public TimeSpan Interval { get; private set; }

        public void Start()
        {
            if (runnig) throw new InvalidOperationException("StartWatch started twice");
            _start = DateTime.Now;
            runnig = true;
        }

        public void Stop()
        {
            if (runnig)
            {
                _end = DateTime.Now;
                Interval = _end - _start;
                runnig = false;
            }
        }

    }
}