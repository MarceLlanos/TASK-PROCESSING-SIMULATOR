using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ExecutorTask : IExecutorTask
    {
        public ITask ExecuteTask(ITask task)
        {
            var valueExecuted = task.GetInstructionsTask() - task.GetExecutedInstructions();
            var actualValueExecuted = valueExecuted - task.GetDataQueueTask().GetExecuteValue();

            if (valueExecuted > 0)
            {
                if (actualValueExecuted > 0)
                {
                    task.SetExecutedInstructions(actualValueExecuted);
                    task.GetDataQueueTask().SetExecuteValue(0);
                }
                else
                {
                    task.GetDataQueueTask().SetExecuteValue(actualValueExecuted*-1);
                }
            }

            return task;
        }
    }
}
