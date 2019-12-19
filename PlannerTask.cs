using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PlannerTask : IPlannerTask
    {
        INextExecutorVerifier verifier;

        public PlannerTask(INextExecutorVerifier verifier)
        {
            this.verifier = verifier;
        }

        public ITask PlanTask(List<ITask> tasks)
        {
            if (tasks == null || tasks.Count == 0)
            {
                return null;
            }

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
