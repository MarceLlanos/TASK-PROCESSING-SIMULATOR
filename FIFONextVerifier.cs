using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class FIFONextVerifier : INextExecutorVerifier
    {
        public bool VerifyNextExecute(ITask firstTask, ITask secondTask)
        {
            bool result = false;
           
            if (firstTask.GetIdTask() < secondTask.GetIdTask())
            {
                result = true;
            }

            return result;
        }
    }
}
