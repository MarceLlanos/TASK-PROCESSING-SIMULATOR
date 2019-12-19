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
        IGenerateId id;
        public Task(IGenerateId id, IDataTask dataTask, IDataQueue dataQueue)
        {
            this.id = id;
            this.dataTask = dataTask;
            this.dataQueue = dataQueue;
            
        }

        public IDataQueue GetDataQueueTask()
        {
            return dataQueue;
        }

        public int GetExecutedInstructions()
        {
            return executedInstruction;
        }

        public IGenerateId GetIdTask()
        {
            return id;
        }

        public int GetInstructionsTask()
        {
            return dataTask.GetInstructionsTask();
        }

        public int GetN()
        {
            return dataQueue.GetNValue();
        }

        public int GetPriorityTask()
        {
            return dataTask.GetPriorityTask();
        }

        public void SetExecutedInstructions(int executedInstructions)
        {
            this.executedInstruction = executedInstructions;
        }

        public void Show()
        {
            Console.WriteLine("id {0}", GetIdTask());
            Console.WriteLine("Priority {0}", GetPriorityTask());
            Console.WriteLine("Instructions {0}", GetInstructionsTask());
            Console.WriteLine("Executed Instructions {0}", GetExecutedInstructions());
            Console.WriteLine("--------------------------");
        }
    }
}
