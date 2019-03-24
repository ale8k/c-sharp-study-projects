using System;

namespace Design_a_workflow_engine
{
    public class Running : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Running");
        }
    }

}

