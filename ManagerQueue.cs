using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ManagerQueue : IManagerQueue
    {
        IQueueTask queueTask;

        public ManagerQueue(IQueueTask queueTask)
        {
            this.queueTask = queueTask;
        }

        public IQueueTask ManageQueue(IPlannerTasks plannerTask)
        {
            var task = plannerTask.PlanTasks(queueTask);

            if (task != null)
            {
                var newTask = new ProcessorTask().ProcessTask(task);

                foreach (var item in queueTask.GetTasks())
                {
                    if (item.GetIdTask().Equals(newTask.GetIdTask()))
                    {
                        queueTask.DeleteTask(item);
                        queueTask.AddTask(newTask);
                    }
                }
            }

            return queueTask;
        }
    }
}
