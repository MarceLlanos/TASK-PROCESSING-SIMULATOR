using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ShortestTaskFirstProcessVerifier : IProcessorTasksVerifier
    {
        public bool VerifyProcessorTasks(ITask firstTask, ITask secondTask)
        {
            bool result = false;

            if (firstTask.GetDataTask().GetInstructionsTask() < secondTask.GetDataTask().GetInstructionsTask())
            {
                return result = true;
            }

            return result;
        }
    }
}
