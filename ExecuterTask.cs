using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ExecuterTask : IExecuterTask
    {
        ITaskQueue queue;

        public ExecuterTask(ITaskQueue queue)
        {
            this.queue = queue;
        }
        public bool ExecuteTask(string option)
        {
            if (option == "EXECUTE")
            {
                return true;
            }

            return false;
        }
    }
}
