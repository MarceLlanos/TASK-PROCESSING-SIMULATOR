using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class FIFOProcessVerifier : IProcessorTasksVerifier
    {
        public bool VerifyProcessorTasks(ITask firstTask, ITask secondTask)
        {
            bool result = false;

            if (firstTask.GetId() < secondTask.GetId())
            {
                result = true;
            }

            return result;
        }
    }
}
