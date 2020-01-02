using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ProcessorTask : IProcessorTask
    {
        IMinimumValue mineValue;
        public ProcessorTask()
        {
            mineValue = new MinimumValue();
        }
        public ITask ProcessTask( ITask task )
        {
            var numberN = task.GetOrchestraInformation().GetNumberN();
            var numberOfExecutions = task.GetOrchestraInformation().GetExecuteInstructionsNumber();
            var pendingInstructions = task.GetPendingInstructions();

            var mineValueFound = mineValue.GetMineNumber( numberN, numberOfExecutions, pendingInstructions );

            task.ExecuteTask( mineValueFound );
            task.GetOrchestraInformation().SetNumberOfExecutions( numberOfExecutions - mineValueFound );

            return task;
        }
    }
}
