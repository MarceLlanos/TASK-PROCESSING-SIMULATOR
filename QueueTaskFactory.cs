using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class QueueTaskFactory : IQueueTaskFactory
    {
        public QueueTaskFactory()
        {
        }

        public IQueueTask CreateQueueTaskFatory(string plannerSort, IDataQueue dataQueue)
        {
            var optionsFactory = new OptionsFactory().PlanneTask(plannerSort);

            return new ManagerQueue(new QueueTask(dataQueue)).ManageQueue(optionsFactory);
        }
    }
}
