using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PlannerTasks : IPlannerTasks
    {
        IProcessorTasksVerifier verifier;

        public PlannerTasks(IProcessorTasksVerifier verifier)
        {
            this.verifier = verifier;
        }

        public ITask PlanTasks(List<ITask> tasks)
        {
            if (tasks == null || tasks.Count == 0)
            {
                return null;
            }

            var result = tasks[0];

            foreach (var item in tasks)
            {
                if (verifier.VerifyProcessorTasks(item, result))
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
