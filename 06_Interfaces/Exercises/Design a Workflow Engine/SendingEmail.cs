using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class SendingEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine
                ("Sending e-mail to owner of video that the processing started...");
        }
    }
}
