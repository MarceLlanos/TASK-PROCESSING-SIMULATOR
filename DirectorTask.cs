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

        public IQueueTask DirectTasks(int execute)
        {
            IQueueTask queueTaskResult = queueTask;
            var processorTask = new ProcessorTask();
            var task = plannerTask.PlanTasks(queueTask.GetTasks());

            while (task != null)
            {
                foreach (var item in queueTaskResult.GetTasks())
                {
                    if (item.GetId() == 0)
                    {
                        queueTask.DeleteTask(item);
                    }

                    if (item == task)
                    {
                        var taskResult = processorTask.ProcessTask(task, execute);
                        queueTaskResult.DeleteTask(item);
                        queueTaskResult.AddTask(taskResult);
                    }
                }
            }

            return queueTaskResult;
        }
    }
}
