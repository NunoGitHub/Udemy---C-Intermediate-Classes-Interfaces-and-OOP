namespace WorkflowEngine
{
    public class MailService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to client");
        }
  
    }
}