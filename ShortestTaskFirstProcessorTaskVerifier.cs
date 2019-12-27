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
            var firstInstructionsNumber= firstTask.GetTaskData().GetTaskInstructionsValue();
            var secondInstructionsNumber = secondTask.GetTaskData().GetTaskInstructionsValue();

            return (firstInstructionsNumber < secondInstructionsNumber );
        }
    }
}
