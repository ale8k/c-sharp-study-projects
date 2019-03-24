using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_workflow_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow myWorkflow = new Workflow();
            myWorkflow.AddActivity(new Running());
            myWorkflow.AddActivity(new Jogging());
            WorkflowEngine myEngine = new WorkflowEngine(myWorkflow);
            System.Console.ReadLine();
        }
    }

}

