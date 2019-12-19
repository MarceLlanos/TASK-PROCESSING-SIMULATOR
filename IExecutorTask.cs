using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    interface IExecutorTask
    {
        void ExecuteTask(ITask task);
    }
}
