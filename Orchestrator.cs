using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Orchestrator: IOrchestrator
    {
        IPlanner plannerTask;
        IProcessorTask processorTask;

        public Orchestrator(IPlanner plannerTask, IProcessorTask processorTask)
        {
            this.plannerTask = plannerTask;
            this.processorTask = processorTask;
            
        }
        
        public ITaskQueue DirectOrchestra(IOrchestraInformation orchestraInformation, ITaskQueue queueTask)
        {
            while (orchestraInformation.GetExecuteInstructionsNumber() > 0)
            {
                var task = plannerTask.ReturnAvailableTask(queueTask.GetTasks());
                var taskResult = processorTask.ProcessTask(task);

                if (!taskResult.IsTaskCompleteExecuted())
                {
                    queueTask.AddTask(taskResult);
                }
            }
            return queueTask;
        }
    }
}
