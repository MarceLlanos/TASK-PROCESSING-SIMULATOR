using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class RoundRobinProcessorTaskVerifier : IProcessorTasksVerifier
    {
        public bool IsBestTaskToProcess(ITask firstTask, ITask secondTask)
        {
            var firstTaskExecutedInstructions = firstTask.GetExecutedInstructions();
            var secondTaskExecutedInstructions = secondTask.GetExecutedInstructions();

            return ( firstTaskExecutedInstructions  < secondTaskExecutedInstructions );
        }
    }
}
