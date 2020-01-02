using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITaskInformation
    {
        int GetPriorityNumber();
        int GetInstructionsNumber();
        int GetExecuteInstructionsNumber();
        int GetNumberN();
        void SetNumberOfExecutions(int executeValue);
        void SetNumberN(int numberN);
    }
}
