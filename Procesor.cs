using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Procesor : IProcessor
    {
        IQueueTask queueTask;

        public Procesor(IQueueTask queueTask)
        {
            this.queueTask = queueTask;
        }

        public ITask Process(IPlannerTask plannerTask, IExecutorTask executorTask)
        {
            ITask result = plannerTask.PlanTask(queueTask.GetTasks(), new FIFONextVerifier());

            if (result.GetInstructionsTask() ==  result.GetExecutedInstructions())
            {
                queueTask.GetTasks().Remove(result);

                return null;
            }

            if (result != null)
            {
                executorTask.ExecuteTask(result, queueTask.GetDataQueue());
            }
            
            return result;
        }
    }
}
