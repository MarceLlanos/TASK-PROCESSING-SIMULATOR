using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITaskQueue
    {
        bool AddTask(ITask task);
        void ShowQueue();
        List<ITask> GetTasks();
        void DeleteTask(ITask task);

    }
}
