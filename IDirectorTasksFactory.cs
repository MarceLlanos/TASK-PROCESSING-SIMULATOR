using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    public interface IDirectorTasksFactory
    {
        IDirectorTask CreateDirectorTasks(string algorithm, IQueueTask queueTask);
    }
}
