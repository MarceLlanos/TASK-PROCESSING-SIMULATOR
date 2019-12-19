using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class TaskFactory : IFactory<ITask>
    {
        IQueueTask queueTask;

        public TaskFactory(IQueueTask queueTask)
        {
            this.queueTask = queueTask;
        }
        public ITask Create()
        {
            return new Task(new DataTask(new GeneratorId(0), 0, 0), queueTask.GetDataQueue());
        }
    }
}
