using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class UploadVideoToCloudStorage : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading to cloud storage...");
        }
    }
}
