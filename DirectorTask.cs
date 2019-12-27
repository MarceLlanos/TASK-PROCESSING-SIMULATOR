using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DirectorTask : IProcessDirector
    {
        IPlannerTasks plannerTask;
        IProcessorTask processorTask;

        public DirectorTask(IPlannerTasks plannerTask, IProcessorTask processorTask)
        {
            this.plannerTask = plannerTask;
            this.processorTask = processorTask;
            
        }
        
        public ITaskQueue DigestProcess(IProcessorData dataQueue, ITaskQueue queueTask)
        {
            while (dataQueue.GetExecuteInstructionsNumber() > 0)
            {
                var task = plannerTask.ExetendTask(queueTask.GetTasks());
                var taskResult = processorTask.ProcessTask(task);

                if (!taskResult.IsTaskCompletedExecuted())
                {
                    queueTask.AddTask(taskResult);
                }
            }
            return queueTask;
        }
    }
}
