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
            var minimumValue = new Minimum().GetMinimum(task.GetDataQueueTask().GetNValue(), task.GetDataQueueTask().GetExecuteValue(), task.GetPendingInstructions());
            var executedValue = minimumValue - task.GetExecutedInstructions();

            if (task.GetExecutedInstructions() > 0 && task.GetExecutedInstructions() < task.GetDataQueueTask().GetNValue())
            {
                task.ExecutedTaskLimitedByN(executedValue);
                task.GetDataQueueTask().SetExecuteValue(task.GetDataQueueTask().GetExecuteValue() - executedValue);

            }
            else
            {
                task.ExecutedTaskLimitedByN(minimumValue);
                task.GetDataQueueTask().SetExecuteValue(task.GetDataQueueTask().GetExecuteValue() - minimumValue);

            }

            return task;
        }
    }
}
