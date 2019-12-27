using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class TaskFactory : ITaskFactory
    {
        IGeneratorId generateId;

        public TaskFactory( IGeneratorId generateId)
        {
            this.generateId = generateId;
        }

        public ITask CreateTask(int priorityNumber, int instructionsNumber, IProcessorData processorData)
        {
            var dataTask = new TaskData(priorityNumber, instructionsNumber);

            return new Task(generateId.GenerateId(), dataTask, processorData);
        }
    }
}
