using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PlannerTask : IPlannerTask
    {
        public ITask PlanTask(List<ITask> tasks, INextExecutorVerifier verifier)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (verifier.VerifyNextExecute(tasks[i], tasks[i++]))
                {
                    return tasks[i];
                }
            }

            return null;
        }
    }
}
