using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ProcessorTask : IProcessorTask
    {
        public ITask ProcessTask(ITask task, int executeValue)
        {
            var resultInstructions = task.GetDataTask().GetInstructionsTask() - task.GetExecutedInstructions();
            var executedInstructions = task.GetExecutedInstructions() + executeValue;

            if ( executedInstructions < task.GetDataTask().GetInstructionsTask())
            {
                task.SetExecutedInstructions(executedInstructions);
                task.GetDataQueueTask().SetExecuteValue(0);
            }

            if ( executedInstructions > task.GetDataTask().GetInstructionsTask())
            {
                task.GetDataQueueTask().SetExecuteValue(executedInstructions - task.GetDataTask().GetInstructionsTask());
                task.SetExecutedInstructions(task.GetDataTask().GetInstructionsTask());
            }

            return task;
        }
    }
}
