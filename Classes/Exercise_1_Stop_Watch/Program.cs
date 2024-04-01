namespace StopWatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();

            Thread.Sleep(2000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Interval.TotalSeconds);
            stopWatch.Start();

            Thread.Sleep(2000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Interval.TotalSeconds);
        }
    }
}