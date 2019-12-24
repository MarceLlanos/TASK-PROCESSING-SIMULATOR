using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DirectorTask : IDirectorTask
    {
        IQueueTask queueTask;
        IPlannerTasks plannerTask;

        public DirectorTask(IPlannerTasks plannerTask, IQueueTask queueTask)
        {
            this.plannerTask = plannerTask;
            this.queueTask = queueTask;
            
        }

        public IQueueTask DirectTasks(IDataQueue dataQueue)
        {
            while (dataQueue.GetExecuteValue() > 0)
            {
                var taskResult = plannerTask.PlanTasks(queueTask.GetTasks());

                var min = new Minimo().IsMinimo(dataQueue.GetNValue(), dataQueue.GetExecuteValue(), taskResult.GetPendingInstructions());
                taskResult.Execute(min);

                dataQueue.SetExecuteValue(dataQueue.GetExecuteValue() - min);

                if (!taskResult.IsCompleted())
                {
                    queueTask.AddTask(taskResult);
                }
            }
            return queueTask;
        }
    }
}
