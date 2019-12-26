using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DirectorTask : IDirectorTask
    {
        IPlannerTasks plannerTask;
        IProcessorTask processorTask;

        public DirectorTask(IPlannerTasks plannerTask, IProcessorTask processorTask)
        {
            this.plannerTask = plannerTask;
            this.processorTask = processorTask;
            
        }
        
        public IQueueTask DirectTasks(IDataQueue dataQueue, IQueueTask queueTask)
        {
            while (dataQueue.GetExecuteValue() > 0)
            {
                var task = plannerTask.PlanTasks(queueTask.GetTasks());
                var taskResult = processorTask.ProcessTask(task);

                if (!taskResult.IsCompleted())
                {
                    queueTask.AddTask(taskResult);
                }
            }
            return queueTask;
        }
    }
}
