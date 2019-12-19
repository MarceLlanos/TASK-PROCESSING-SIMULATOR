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
            if (task.GetInstructionsTask() > task.GetExecutedInstructions())
            {
                var taskResult = new ExecutorTask().ExecuteTask(task);

                if (taskResult.GetInstructionsTask() == task.GetExecutedInstructions())
                {
                    
                }

                return taskResult;
            }

            return null;
        }
    }
}
