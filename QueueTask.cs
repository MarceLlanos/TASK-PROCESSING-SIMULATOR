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
            if (task.GetDataTask().GetPriorityTask() > 0 || task.GetDataTask().GetInstructionsTask() > 0)
            {
                tasks.Add(task);
                return true;
            }

            return false;
        }

        public ITask DequeueTask(ITask task)
        {
            ITask resultTask = null;

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] == task)
                {
                    resultTask = tasks[i];
                    tasks.Insert(0, resultTask);
                    tasks.RemoveAt(i+1);
                }
            }

            return resultTask;
        }

        public void DeleteTask()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].GetDataTask().GetInstructionsTask() == tasks[i].GetPendingInstructions())
                {
                    tasks.RemoveAt(i);
                }
            }
        }

        public List<ITask> GetTasks()
        {
            return tasks;
        }

        public void ShowQueue()
        {
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
