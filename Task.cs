using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Task : ITask
    {
        ITaskData taskData;
        IProcessorData processorData;
        int numberOfInstructionsExecuted;
        int id;

        public Task( int id, ITaskData taskData, IProcessorData processorData )
        {
            this.id = id;
            this.taskData = taskData;
            this.processorData = processorData;
            numberOfInstructionsExecuted = 0;
            
        }

        public void ExecuteTask( int instructions )
        {
            numberOfInstructionsExecuted += instructions;
        }

        public void ExecuteTaskLimitedByN( int instructions )
        {
            var nValue = processorData.GetNumberN();

            if (instructions >=  nValue)
            {
                numberOfInstructionsExecuted += nValue;
            }

            if(instructions < nValue)
            {
                numberOfInstructionsExecuted += instructions;   
            }
        }

        public IProcessorData GetProcessorData()
        {
            return processorData;
        }

        public ITaskData GetTaskData()
        {
            return taskData;
        }

        public int GetId()
        {
            return id;
        }

        public bool IsTaskCompletedExecuted()
        {
            return (numberOfInstructionsExecuted == taskData.GetTaskInstructionsValue());
        }

        public void SetExecutedInstructions( int executedInstructions )
        {
            this.numberOfInstructionsExecuted = executedInstructions;
        }

        public int GetPendingInstructions()
        {
            return taskData.GetTaskInstructionsValue() - numberOfInstructionsExecuted;
        }

        public int GetExecutedInstructions()
        {
            return numberOfInstructionsExecuted;
        }

        public void Show()
        {
            Console.WriteLine("id {0}", GetId());
            Console.WriteLine("Priority {0}", taskData.GetTaskPriorityNumber());
            Console.WriteLine("Instructions {0}", taskData.GetTaskInstructionsValue());
            Console.WriteLine("Executed Instructions {0}", numberOfInstructionsExecuted);
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
        }

        
    }
}
