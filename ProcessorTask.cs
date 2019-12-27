using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ProcessorTask : IProcessorTask
    {
        public ITask ProcessTask(ITask task)
        {
            var nValue = task.GetDataQueueTask().GetNValue();
            var executeInstructionsValue = task.GetDataQueueTask().GetExecuteInstructionsValue();
            var pendingInstructions = task.GetPendingInstructions();

            var minimumValueFound = new Minimum().GetMinimum(nValue, executeInstructionsValue, pendingInstructions);

            task.ExecuteTask(minimumValueFound);
            task.GetDataQueueTask().SetExecuteInstructionsValue(executeInstructionsValue - minimumValueFound);

            return task;
        }
    }
}
