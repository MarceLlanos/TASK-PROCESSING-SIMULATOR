using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class QueueFactory : IQueueFactory
    {
        public IProcessor ProcessorTask(string processor)
        {
            switch (processor)
            {
                case "FIFO":
                    return new FIFOProcessorFactory().Create();

                case "Priority Based":
                    return new PriorityBaseProcessorFactory().Create();

                case "Shortest Task First":
                    return new ShortestTaskProcessorFactory().Create();

                default:
                    return new FIFOProcessorFactory().Create();
            }
        }
    }
}
