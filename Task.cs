using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Task : ITask
    {
        ITaskInformation taskData;
        IOrchestraInformation orchestraInformation;
        int numberOfInstructionsExecuted;
        int id;

        public Task(int id, ITaskInformation taskData, IOrchestraInformation orchestraInformation)
        {
            this.id = id;
            this.taskData = taskData;
            this.orchestraInformation = orchestraInformation;
            numberOfInstructionsExecuted = 0;

        }

        public void ExecuteTask(int instructions)
        {
            numberOfInstructionsExecuted += instructions;
        }

        public void ExecuteTaskLimitedByN(int instructions)
        {
            var nValue = orchestraInformation.GetNumberN();

            if (instructions >= nValue)
            {
                numberOfInstructionsExecuted += nValue;
            }

            if (instructions < nValue)
            {
                numberOfInstructionsExecuted += instructions;
            }
        }

        public IOrchestraInformation GetOrchestraInformation()
        {
            return orchestraInformation;
        }

        public ITaskInformation GetTaskData()
        {
            return taskData;
        }

        public int GetId()
        {
            return id;
        }

        public bool IsTaskCompleteExecuted()
        {
            return (numberOfInstructionsExecuted == taskData.GetInstructionsNumber());
        }

        public void SetExecutedInstructions(int executedInstructions)
        {
            this.numberOfInstructionsExecuted = executedInstructions;
        }

        public int GetPendingInstructions()
        {
            return taskData.GetInstructionsNumber() - numberOfInstructionsExecuted;
        }

        public int GetExecutedInstructions()
        {
            return numberOfInstructionsExecuted;
        }

        public void Show()
        {
            Console.WriteLine("id {0}", GetId());
            Console.WriteLine("Priority {0}", taskData.GetPriorityNumber());
            Console.WriteLine("Instructions {0}", taskData.GetInstructionsNumber());
            Console.WriteLine("Executed Instructions {0}", numberOfInstructionsExecuted);
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
        }

    }
}
