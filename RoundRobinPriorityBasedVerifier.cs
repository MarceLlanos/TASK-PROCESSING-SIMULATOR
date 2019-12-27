using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class RoundRobinPriorityBasedVerifier : IProcessorTasksVerifier
    {
        public bool IsBestTaskToProcess(ITask firstTask, ITask secondTask)
        {
            return false;
        }
    }
}
