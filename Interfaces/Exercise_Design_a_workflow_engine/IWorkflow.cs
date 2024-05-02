namespace WorkflowEngine
{
    public interface IWorkflow
    {
        public void add(ITask task);

        public void remove(ITask task);

        public IEnumerable<ITask> GetTask();
    }
}