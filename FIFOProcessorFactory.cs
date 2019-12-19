using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class FIFOProcessorFactory : IFactory<IProcessor>
    {
        IQueueTask queueTask;

        public FIFOProcessorFactory(IQueueTask queueTask)
        {
            this.queueTask = queueTask
                ;
        }
        public IProcessor Create()
        {
            return null;
        }

    }
}
