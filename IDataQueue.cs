using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    public interface IDataQueue
    {
        int GetNValue();
        int GetExecuteInstructionsValue();
        void SetExecuteInstructionsValue(int executeInstructionsValue);
        int executeInstructionsValueResult(int resultInstructionExecuted, int execute);

    }
}
