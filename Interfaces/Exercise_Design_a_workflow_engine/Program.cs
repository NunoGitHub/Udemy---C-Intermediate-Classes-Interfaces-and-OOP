namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Workflow();
            work.add(new VideoUpload());
            work.add(new EncodeVideo());
            work.add(new MailService());
            work.add(new ChangeStatus());
            var engine = new WorkFlowEngine();
            engine.Run(work);
        }
    }
}