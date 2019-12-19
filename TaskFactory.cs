using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class TaskFactory : ITaskFactory
    {

        public TaskFactory()
        {
        }
        public ITask Create(IDataTask dataTask, IDataQueue dataQueue)
        {
            return new Task(new GeneratorId(0), dataTask, dataQueue);
        }
    }
}
