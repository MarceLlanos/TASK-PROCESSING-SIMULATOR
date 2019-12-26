using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PriorityBasedProcessVerifier : IProcessorTasksVerifier
    {
        public bool VerifyProcessorTasks(ITask firstTask, ITask secondTask)
        {
            return (firstTask.GetDataTask().GetPriorityTask() < secondTask.GetDataTask().GetPriorityTask());
        }
    }
}
