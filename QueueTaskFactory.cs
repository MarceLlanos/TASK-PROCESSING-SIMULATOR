using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class QueueTaskFactory : IQueueTaskFactory
    {
        public IQueueTask CreateQueueTaskFatory(int nValue)
        {
            return new QueueTask(nValue);
        }
    }
}
