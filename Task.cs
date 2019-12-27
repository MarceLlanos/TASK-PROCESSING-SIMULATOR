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
        int executedInstructions;
        int id;

        public Task(int id, IDataTask dataTask, IDataQueue dataQueue)
        {
            this.id = id;
            this.dataTask = dataTask;
            this.dataQueue = dataQueue;
            executedInstructions = 0;
            
        }

        public void ExecuteTask( int instructions )
        {
            executedInstructions += instructions;
        }

        public void ExecuteTaskLimiteByN( int instructions )
        {
            var nValue = dataQueue.GetNValue();

            if (instructions >=  nValue)
            {
                executedInstructions += nValue;
            }

            if(instructions < nValue)
            {
                executedInstructions += instructions;   
            }
        }

        public IDataQueue GetDataQueueTask()
        {
            return dataQueue;
        }

        public IDataTask GetDataTask()
        {
            return dataTask;
        }

        public int GetId()
        {
            return id;
        }

        public bool IsTaskCompletedExecuted()
        {
            return (executedInstructions == dataTask.GetTaskInstructionsValue());
        }

        public void SetExecutedInstructions( int executedInstructions )
        {
            this.executedInstructions = executedInstructions;
        }

        public int GetPendingInstructions()
        {
            return dataTask.GetTaskInstructionsValue() - executedInstructions;
        }

        public int GetExecutedInstructions()
        {
            return executedInstructions;
        }

        public void Show()
        {
            Console.WriteLine("id {0}", GetId());
            Console.WriteLine("Priority {0}", dataTask.GetTaskPriorityValue());
            Console.WriteLine("Instructions {0}", dataTask.GetTaskInstructionsValue());
            Console.WriteLine("Executed Instructions {0}", executedInstructions);
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
        }

        
    }
}
