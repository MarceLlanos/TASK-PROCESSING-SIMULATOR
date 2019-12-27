using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class FIFOProcessorTaskVerifier : IProcessorTasksVerifier
    {
        public bool IsBestTaskToProcess( ITask firstTask, ITask secondTask )
        {
            var firstIdTask = firstTask.GetId();
            var secondIdTask = secondTask.GetId();

            return ( firstIdTask  < secondIdTask );
        }
    }
}
