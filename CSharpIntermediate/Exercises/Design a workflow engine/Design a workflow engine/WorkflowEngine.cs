namespace Design_a_workflow_engine
{
    public class WorkflowEngine
    {
        public WorkflowEngine(Workflow workflow)
        {
            Run(workflow);
        }

        public void Run(Workflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities)
            {
                activity.Execute();
            }
        }
    }
}
