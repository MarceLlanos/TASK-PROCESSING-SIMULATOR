using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ExecuteWrittenAction : IReceiver
    {
        ITaskQueue taskQueue;
        IOrchestraInformation orchestraInformation;

        public ExecuteWrittenAction(IOrchestraInformation orchestraInformation, ITaskQueue taskQueue)
        {
            this.taskQueue = taskQueue;
            this.orchestraInformation = orchestraInformation;

        }

        public bool Action(string option)
        {
            if (option == "EXECUTE")
            {
                return true;
            }

            return false;
        }
    }
}
