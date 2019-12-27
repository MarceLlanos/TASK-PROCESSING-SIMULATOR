using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DataQueue : IDataQueue
    {
        int nValue;
        int executeValue;

        public DataQueue(int nValue)
        {
            this.nValue = nValue;
            executeValue = 0;
        }

        public int GetExecuteInstructionsValue()
        {
            return executeValue;
        }

        public int GetNValue()
        {
            return nValue;
        }

        public void SetExecuteInstructionsValue(int executeValue)
        {
            this.executeValue = executeValue;
        }

        public int executeInstructionsValueResult(int resultInstruction, int execute)
        {
            return resultInstruction - execute;
        }
    }
}
