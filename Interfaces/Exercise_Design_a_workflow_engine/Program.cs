namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Engine();
            work.ProcessData(new VideoUpload());
            work.ProcessData(new EncodeVideo());
            work.ProcessData(new MailService());
            work.Run();
        }
    }
}