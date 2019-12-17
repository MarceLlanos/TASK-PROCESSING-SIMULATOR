using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PlannerTask : IPlannerTask
    {
        public ITask PlanTask(ITask[] tasks, INextExecutorVerifier verifier)
        {
            for (int i = 0; i < tasks.Length; )
            {
                if (verifier.VerifyNextExecute(tasks[i], tasks[i++]))
                {
                    return tasks[i];
                }
                else
                {
                    i++;
                }
            }

            return null;
        }
    }
}
