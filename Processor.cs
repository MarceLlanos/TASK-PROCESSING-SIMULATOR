using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Processor : IProcessor
    {
        IQueueTask queueTask;
        IPlannerTask plannerTask;

        public Processor(IPlannerTask plannerTask)
        {
            this.plannerTask = plannerTask;
        }

        public ITask Process(IExecutorTask executorTask)
        {
            ITask task = plannerTask.PlanTask(queueTask.GetTasks());

            if (task.GetInstructionsTask() >=  task.GetExecutedInstructions())
            {
                queueTask.GetTasks().Remove(task);
            }

            if (task != null)
            {
                foreach (var item in queueTask.GetTasks())
                {
                    if (task == item)
                    {
                        executorTask.ExecuteTask(item);
                    }
                }
            }

            return task;
        }
    }
}
