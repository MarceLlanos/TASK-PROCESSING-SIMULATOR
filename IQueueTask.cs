using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    interface IQueueTask
    {
        void AddTask(ITask task);
        void DeleteTask(ITask task);
        void ShowQueue();
        List<ITask> GetTasks();
        IDataQueue GetDataQueue();
    }
}
