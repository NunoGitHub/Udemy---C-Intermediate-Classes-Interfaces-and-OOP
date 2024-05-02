namespace WorkflowEngine
{
    public class WorkFlowEngine 
    {
        
        public void Run( IWorkflow workflow)
        {
            if (workflow.GetTask().Count() == 0 || workflow == null)
                throw new InvalidOperationException("No workflow found");

            foreach (var item in workflow.GetTask())
            {
                try
                {
                    item.Execute();
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine($"Error in foreach: {ex.Message}");

                }
            }
            
        }

        

    }
}