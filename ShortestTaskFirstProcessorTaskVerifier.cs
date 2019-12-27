using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ShortestTaskFirstProcessorTaskVerifier : IProcessorTasksVerifier
    {
        public bool IsBestTaskToProcess( ITask firstTask, ITask secondTask )
        {
            var firstTaskInstructionsValue = firstTask.GetTaskData().GetTaskInstructionsValue();
            var secondTaskInstructionsValue = secondTask.GetTaskData().GetTaskInstructionsValue();

            return ( firstTaskInstructionsValue < secondTaskInstructionsValue );
        }
    }
}
