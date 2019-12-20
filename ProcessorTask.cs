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
            if(task.GetDataTask().GetInstructionsTask() - task.GetExecutedInstructions()> 0)
            {
                var instructionsExecuted = task.GetDataTask().GetInstructionsTask() - task.GetExecutedInstructions();
                var nowInstructionsExecuted = instructionsExecuted - executeValue;

                if (nowInstructionsExecuted > 0)
                {
                    task.SetExecutedInstructions(executeValue + task.GetExecutedInstructions());
                    task.GetDataQueueTask().SetExecuteValue(0);
                }

                if(nowInstructionsExecuted < 0)
                {
                    task.SetId(0);
                    task.GetDataQueueTask().SetExecuteValue(nowInstructionsExecuted *-1);
                }

                if (nowInstructionsExecuted == 0)
                {
                    task.SetId(0);
                    task.GetDataQueueTask().SetExecuteValue(0);
                }
            }

            return task;
        }
    }
}
