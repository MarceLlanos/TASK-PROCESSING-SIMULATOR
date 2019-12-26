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
            var min = new Minimum().GetMinimum(task.GetDataQueueTask().GetNValue(), task.GetDataQueueTask().GetExecuteValue(), task.GetPendingInstructions());

            task.ExecuteTask(min);
            task.GetDataQueueTask().SetExecuteValue(task.GetDataQueueTask().GetExecuteValue() - min);

            return task;
        }
    }
}
