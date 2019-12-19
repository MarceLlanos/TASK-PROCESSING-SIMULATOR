using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class QueueTask : IQueueTask
    {
        List<ITask> tasks;
        IDataQueue dataQueue;

        public QueueTask( IDataQueue dataQueue)
        {
            this.dataQueue = dataQueue;
            tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            tasks.Add(task);
        }

        public void DeleteTask(ITask task)
        {
            tasks.Remove(task);
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
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("N Value: {0}", dataQueue.GetNValue());
            Console.WriteLine("Execute Value: {0}", dataQueue.GetExecuteValue());

            foreach (var item in tasks)
            {
                item.Show();
            }

            Console.WriteLine("-----------------------------------------");
        }
    }
}
