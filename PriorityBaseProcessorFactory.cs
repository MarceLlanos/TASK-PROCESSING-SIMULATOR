using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PriorityBaseProcessorFactory : IFactory<IProcessor>
    {
        public IProcessor Create()
        {
            return null;
        }
    }
}
