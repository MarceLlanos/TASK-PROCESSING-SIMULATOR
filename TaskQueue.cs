using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class TaskQueue : ITaskQueue
    {
        List<ITask> tasks;
        int numberN;

        public TaskQueue( int numberN )
        {
            this.numberN = numberN;
            tasks = new List<ITask>();
        }

        public bool AddTask( ITask task )
        {
            var numberN = task.GetTaskData().GetPriorityNumber();
            var taskInstructionsValue = task.GetTaskData().GetInstructionsNumber();

            if (numberN > 0 && taskInstructionsValue > 0)
            {
                DeleteTask(task);
                tasks.Add(task);

                return true;
            }

            return false;
        }

        public void DeleteTask( ITask task )
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
            Console.WriteLine("N Value: {0}", numberN);

            foreach (var item in tasks)
            {
                item.Show();
            }

            Console.WriteLine("-----------------------------------------");
        }
    }
}
