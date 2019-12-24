using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    public interface IProcessorTask<T>
    {
        ITask ProcessTask(ITask task, T t);
    }
}
