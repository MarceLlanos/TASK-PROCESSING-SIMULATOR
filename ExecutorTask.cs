using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ExecutorTask : IExecutorTask
    {
        public void ExecuteTask( ITask task, IDataQueue dataQueue)
        {
            int result = 0;

            if (dataQueue.GetExecuteValue() > task.GetInstructionsTask())
            {
                result = dataQueue.GetExecuteValue() - task.GetInstructionsTask();
                task.SetExecutedInstructions(0);
                dataQueue.SetExecuteValue(result);
            }

            if (task.GetInstructionsTask() > dataQueue.GetExecuteValue())
            {
                result = task.GetExecutedInstructions() + dataQueue.GetExecuteValue();
                task.SetExecutedInstructions(result);
                dataQueue.SetExecuteValue(0);
            }
        }
    }
}
