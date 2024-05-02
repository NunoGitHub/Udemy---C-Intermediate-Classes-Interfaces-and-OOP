namespace WorkflowEngine
{
    public class MailService : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to client");
        }
    }
}