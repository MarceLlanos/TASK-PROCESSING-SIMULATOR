using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ShowWrittenAction : IReceiver
    {
        ITaskQueue taskQueue;

        public ShowWrittenAction(ITaskQueue taskQueue)
        {
            this.taskQueue = taskQueue;
        }

        public bool Action(string option)
        {
            if ( option == "SHOW")
            {
                Console.WriteLine("");
                taskQueue.ShowQueue();
                Console.WriteLine("");

                return true;
            }

            return false;
        }
    }
}
