using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OrchestraInformation : IOrchestraInformation
    {
        int numberN;
        int numberExecutions;

        public OrchestraInformation(int numberN)
        {
            this.numberN = numberN;
            numberExecutions = 0;
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
    }
}
