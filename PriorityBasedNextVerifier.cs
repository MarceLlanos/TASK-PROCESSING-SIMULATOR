using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PriorityBasedNextVerifier : INextExecutorVerifier
    {
        public bool VerifyNextExecute(ITask firstTask, ITask secondTask)
        {
            bool result = false;

            if (firstTask.GetPriorityTask() < secondTask.GetPriorityTask())
            {
                result = true;
            }

            return result;
        }
    }
}
