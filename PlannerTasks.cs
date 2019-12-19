using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PlannerTasks : IPlannerTasks
    {
        INextExecutorVerifier verifier;

        public PlannerTasks(INextExecutorVerifier verifier)
        {
            this.verifier = verifier;
        }

        public ITask PlanTasks(IQueueTask queueTask)
        {
            var tasks = queueTask.GetTasks();
            ITask result = null;

            if (tasks == null || tasks.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                if (verifier.VerifyNextExecute(tasks[i], tasks[i++]))
                {
                    return result = tasks[i];
                }
            }

            return result;
        }
    }
}
