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
        int nValue;

        public QueueTask(int nValue)
        {
            this.nValue = nValue;
            tasks = new List<ITask>();
        }

        public bool AddTask(ITask task)
        {
            var nValue = task.GetDataTask().GetTaskPriorityValue();
            var taskInstructionsValue = task.GetDataTask().GetTaskInstructionsValue();

            if (nValue > 0 && taskInstructionsValue > 0)
            {
                DeleteTask(task);
                tasks.Add(task);

                return true;
            }

            return false;
        }

        public void DeleteTask(ITask task)
        {
            tasks.Remove(task);
        }

        public List<ITask> GetTasks()
        {
            return tasks;
        }

        public void ShowQueue()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("N Value: {0}", nValue);

            foreach (var item in tasks)
            {
                item.Show();
            }

            Console.WriteLine("-----------------------------------------");
        }
    }
}
