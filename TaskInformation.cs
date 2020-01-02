using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class TaskInformation: ITaskInformation
    {
        int priorityNumber;
        int instructionsNumber;
        int numberN;
        int numberExecutions;

        public TaskInformation( int priorityNumber, int instructionsNumber)
        {
            this.priorityNumber = priorityNumber;
            this.instructionsNumber = instructionsNumber;
            numberN = 0;
            numberExecutions = 0;
        }

        public int GetInstructionsNumber()
        {
            return instructionsNumber;
        }

        public int GetPriorityNumber()
        {
            return priorityNumber;
        }
        public int GetExecuteInstructionsNumber()
        {
            return numberExecutions;
        }

        public int GetNumberN()
        {
            return numberN;
        }

        public void SetNumberOfExecutions(int executeValue)
        {
            this.numberExecutions = executeValue;
        }

        public void SetNumberN(int numberN)
        {
            this.numberN = numberN;
        }
    }
}
