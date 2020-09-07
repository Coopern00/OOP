using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new Workflow();
            workFlow.Add(new UploadVideoToCloudStorage());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendingEmail());
            workFlow.Add(new ChangeStatus());

            var engine = new WorkflowEngine();
            engine.Run(workFlow);

            Console.ReadLine();

        }
    }
}
