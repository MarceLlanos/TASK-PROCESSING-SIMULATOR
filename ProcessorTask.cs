using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ProcessorTask : IProcessorTask<int>
    {
        public ITask ProcessTask(ITask task, int executeValue)
        {
            var executedInstructions = task.GetPendingInstructions() + executeValue;
            var resultExecutions = executedInstructions - task.GetDataTask().GetInstructionsTask();

            if (task.GetDataTask().GetInstructionsTask() < executedInstructions )
            {
                task.GetDataQueueTask().SetExecuteValue(resultExecutions);
                task.SetExecutedInstructions(task.GetDataTask().GetInstructionsTask());
            }

            if (task.GetDataTask().GetInstructionsTask() == executedInstructions)
            {
                task.SetExecutedInstructions(task.GetDataTask().GetInstructionsTask());
                task.GetDataQueueTask().SetExecuteValue(0);
            }

            if (task.GetDataTask().GetInstructionsTask() > executedInstructions)
            {
                task.GetDataQueueTask().SetExecuteValue(executedInstructions);
            }

            return task;
        }
    }
}
