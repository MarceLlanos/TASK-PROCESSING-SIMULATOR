using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class RoundRobinProcessVerifier : IProcessorTasksVerifier
    {
        public bool VerifyProcessorTasks(ITask firstTask, ITask secondTask)
        {
            return (firstTask.GetExecutedInstructions() < secondTask.GetExecutedInstructions());
        }
    }
}
