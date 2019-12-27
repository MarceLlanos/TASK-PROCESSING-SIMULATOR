using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class RoundRobinProcessorTask : IProcessorTask
    {
        public ITask ProcessTask( ITask task )
        {
            var numberN = task.GetProcessorData().GetNumberN();
            var numberExecutions = task.GetProcessorData().GetExecuteInstructionsNumber();
            var pendingInstructions = task.GetPendingInstructions();
            var instructionsExecuted = task.GetExecutedInstructions();

            var mineNumberFound = new Minimum().GetMinimum( numberN, numberExecutions, pendingInstructions );
            var numberToExecute = mineNumberFound - instructionsExecuted;

            if ( instructionsExecuted > 0 && instructionsExecuted < numberN )
            {
                task.ExecuteTaskLimitedByN(numberToExecute);
                task.GetProcessorData().SetNumberOfExecutions( numberExecutions - numberToExecute );

            }
            else
            {
                task.ExecuteTaskLimitedByN(mineNumberFound);
                task.GetProcessorData().SetNumberOfExecutions( numberExecutions - mineNumberFound );

            }

            return task;
        }
    }
}
