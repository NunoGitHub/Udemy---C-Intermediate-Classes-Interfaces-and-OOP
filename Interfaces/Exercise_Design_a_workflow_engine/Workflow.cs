namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _task;

        public Workflow()
        {
            _task = new List<ITask>();
        }
        public void add(ITask task)
        {
            _task.Add(task);
        }


        public void remove(ITask task)
        {
            _task.Remove(task);
        }

        public IEnumerable<ITask> GetTask()
        {
            return _task;
        }
    }
}