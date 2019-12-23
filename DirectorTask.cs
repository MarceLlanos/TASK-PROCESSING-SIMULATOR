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
            for (int i = 0; i < queueTask.GetTasks().Count; i++)
            {
                var task = plannerTask.PlanTasks(queueTask.GetTasks());

                if (queueTask.GetTasks()[i] == task)
                {
                    var taskProcessed = new ProcessorTask().ProcessTask(task, dataQueue.GetExecuteValue());
                    queueTask.DequeueTask(taskProcessed);
                }

            }

            return queueTask;
        }
    }
}
