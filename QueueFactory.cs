using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class QueueFactory : IFactory<IQueueTask>
    {
        public IQueueTask Create()
        {
            return new ManagerQueue(new QueueTask(new DataQueue(0,0))).ManageQueue();
        }
    }
}
