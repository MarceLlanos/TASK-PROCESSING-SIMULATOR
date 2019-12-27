using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class QueueTaskFactory : ITaskQueueFactory
    {
        public ITaskQueue CreateTaskQueueFatory(int numberN)
        {
            return new TaskQueue(numberN);
        }
    }
}
