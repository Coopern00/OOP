using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine
                ("Calling web serivce to notify them that you have a video ready for encoding...");
        }
    }
}
