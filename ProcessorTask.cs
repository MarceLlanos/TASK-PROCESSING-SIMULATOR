using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ProcessorTask : IProcessorTask
    {
        public ITask ProcessTask( ITask task )
        {
            var numberN = task.GetProcessorData().GetNumberN();
            var numberOfExecutions = task.GetProcessorData().GetExecuteInstructionsNumber();
            var pendingInstructions = task.GetPendingInstructions();

            var mineValueFound = new Minimum().GetMinimum( numberN, numberOfExecutions, pendingInstructions );

            task.ExecuteTask( mineValueFound );
            task.GetProcessorData().SetNumberOfExecutions( numberOfExecutions - mineValueFound );

            return task;
        }
    }
}
