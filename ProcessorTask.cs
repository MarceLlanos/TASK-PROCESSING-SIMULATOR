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
            var numberN = task.GetDataQueueTask().GetNumberN();
            var numberExecutions = task.GetDataQueueTask().GetExecuteInstructionsNumber();
            var pendingInstructions = task.GetPendingInstructions();

            var mineValueFound = new Minimum().GetMinimum(numberN, numberExecutions, pendingInstructions);

            task.ExecuteTask(mineValueFound);
            task.GetDataQueueTask().SetNumberOfExecutions(numberExecutions - mineValueFound);

            return task;
        }
    }
}
