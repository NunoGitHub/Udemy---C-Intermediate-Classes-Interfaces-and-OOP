namespace WorkflowEngine
{
    public class Engine 
    {
        private readonly IList<IWorkflow>  _workflow ;

        public Engine()
        {
            this._workflow = new List<IWorkflow>();
        }
        public void Run()
        {
            if (_workflow.Count == 0 || _workflow == null)
                throw new InvalidOperationException("No workflow found");

            foreach (var item in _workflow)
            {
                try
                {
                    item.Execute();
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine($"Ocorreu um erro ao executar a atividade: {ex.Message}");

                }
            }
            Console.WriteLine("processing...");
        }

        public void ProcessData(IWorkflow video)
        {
            _workflow.Add(video);
        }

    }
}