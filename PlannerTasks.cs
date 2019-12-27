using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PlannerTasks : IPlanner
    {
        IProcessorTasksVerifier verifyTaskToProcess;

        public PlannerTasks(IProcessorTasksVerifier verifyTaskToProcess)
        {
            this.verifyTaskToProcess = verifyTaskToProcess;
        }

        public ITask ExetendTask(List<ITask> tasks)
        {
            if (tasks == null || tasks.Count == 0)
            {
                return null;
            }

            var result = tasks[0];

            foreach (var item in tasks)
            {
                if (verifyTaskToProcess.IsBestTaskToProcess(item, result))
                {
                    result = item;
                    tasks.Remove(result);
                    break;
                }
            }
             
            return result;
        }
    }
}
