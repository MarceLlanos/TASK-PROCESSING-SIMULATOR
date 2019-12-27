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
            var nValue = task.GetDataQueueTask().GetNValue();
            var executeValue = task.GetDataQueueTask().GetExecuteInstructionsValue();
            var pendingValue = task.GetPendingInstructions();
            var executedInstructions = task.GetExecutedInstructions();


            var minimumValueToExecute = new Minimum().GetMinimum(nValue, executeValue, pendingValue);
            var valueResultExecuted = minimumValueToExecute - task.GetExecutedInstructions();

            if ( executedInstructions > 0 && executedInstructions < nValue)
            {
                task.ExecuteTaskLimiteByN(valueResultExecuted);
                task.GetDataQueueTask().SetExecuteInstructionsValue(executeValue - valueResultExecuted);

            }
            else
            {
                task.ExecuteTaskLimiteByN(minimumValueToExecute);
                task.GetDataQueueTask().SetExecuteInstructionsValue(executeValue - minimumValueToExecute);

            }

            return task;
        }
    }
}
