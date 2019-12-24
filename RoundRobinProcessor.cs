using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class RoundRobinProcessor:IProcessorTask<IDataQueue>
    {
        public ITask ProcessTask(ITask task, IDataQueue dataQueue)
        {
            var executeValue = task.GetPendingInstructions() + dataQueue.GetExecuteValue();
            var processor = new ProcessorTask();
            ITask result = null;

            if (executeValue >  dataQueue.GetNValue())
            {
                result = processor.ProcessTask(task, dataQueue.GetNValue());
                task.GetDataQueueTask().SetExecuteValue(result.GetDataQueueTask().GetExecuteValue());
            }

            if (executeValue <= dataQueue.GetNValue())
            {
                result = processor.ProcessTask(task, executeValue);
                task.GetDataQueueTask().SetExecuteValue(result.GetDataQueueTask().GetExecuteValue());
            }

            return task;
        }
    }
}
