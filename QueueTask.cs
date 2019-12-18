using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class QueueTask : IQueueTask
    {
        IProcessor processor;
        List<ITask> tasks;
        IDataQueue dataQueue;

        public QueueTask(List<ITask> tasks, IDataQueue dataQueue, IProcessor processor )
        {
            this.processor = processor;
            this.tasks = tasks;
            this.dataQueue = dataQueue;
        }

        public void AddTask(ITask task)
        {
            tasks.Add(task);
        }

        public void DeleteTask()
        {
            throw new NotImplementedException();
        }

        public IDataQueue GetDataQueue()
        {
            return dataQueue;
        }

        public List<ITask> GetTasks()
        {
            return tasks;
        }

        public void ShowQueue()
        {
            throw new NotImplementedException();
        }
    }
}
