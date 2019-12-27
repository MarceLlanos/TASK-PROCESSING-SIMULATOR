using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class RoundRobinProcessorTask : IProcessorTask
    {
        public ITask ProcessTask(ITask task)
        {
            var numberN = task.GetDataQueueTask().GetNumberN();
            var numberExecutions = task.GetDataQueueTask().GetExecuteInstructionsNumber();
            var pendingInstructions = task.GetPendingInstructions();
            var instructionsExecuted = task.GetExecutedInstructions();


            var mineNumberFound = new Minimum().GetMinimum(numberN, numberExecutions, pendingInstructions);
            var numberToExecute = mineNumberFound - instructionsExecuted;

            if ( instructionsExecuted > 0 && instructionsExecuted < numberN)
            {
                task.ExecuteTaskLimitedByN(numberToExecute);
                task.GetDataQueueTask().SetNumberOfExecutions(numberExecutions - numberToExecute);

            }
            else
            {
                task.ExecuteTaskLimitedByN(mineNumberFound);
                task.GetDataQueueTask().SetNumberOfExecutions(numberExecutions - mineNumberFound);

            }

            return task;
        }
    }
}
