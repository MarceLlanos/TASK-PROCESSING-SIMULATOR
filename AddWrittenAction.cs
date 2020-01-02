using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class AddWrittenAction : IReceiver
    {
        ITaskQueue queue;
        ITaskFactory task;
        ITaskInformation taskInformation;

        public AddWrittenAction(ITaskQueue queue, ITaskFactory task, ITaskInformation taskInformation)
        {
            this.queue = queue;
            this.task = task;
            this.taskInformation = taskInformation;
        }

        public bool Action(string option)
        {
            if (option == "ADD")
            {

                return true;
            }

            return false;
        }
    }
}
