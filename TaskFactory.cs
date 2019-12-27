using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class TaskFactory : ITaskFactory
    {
        IGenerateId generateId;

        public TaskFactory( IGenerateId generateId)
        {
            this.generateId = generateId;
        }

        public ITask CreateTask(int priority, int instructions, IProcessorData dataQueue)
        {
            var dataTask = new TaskData(priority, instructions);

            return new Task(generateId.GenerateId(), dataTask, dataQueue);
        }
    }
}
