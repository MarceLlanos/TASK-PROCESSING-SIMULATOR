using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Task : ITask
    {
        IDataTask dataTask;
        IDataQueue dataQueue;
        int executedInstruction;
        int id;

        public Task(int id, IDataTask dataTask, IDataQueue dataQueue)
        {
            this.id = id;
            this.dataTask = dataTask;
            this.dataQueue = dataQueue;
            
        }

        public IDataQueue GetDataQueueTask()
        {
            return dataQueue;
        }

        public IDataTask GetDataTask()
        {
            return dataTask;
        }

        public int GetExecutedInstructions()
        {
            return executedInstruction;
        }

        public int GetId()
        {
            return id;
        }

        public void SetExecutedInstructions(int executedInstructions)
        {
            this.executedInstruction = executedInstructions;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void Show()
        {
            Console.WriteLine("id {0}", GetId());
            Console.WriteLine("Priority {0}", dataTask.GetPriorityTask());
            Console.WriteLine("Instructions {0}", dataTask.GetInstructionsTask());
            Console.WriteLine("Executed Instructions {0}", executedInstruction);
            Console.WriteLine("--------------------------");
        }
    }
}
