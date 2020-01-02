using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class MinimumValue : IMinimumValue
    {
        public int GetMineNumber( int numberN, int numberExecutions, int pendingInstructions )
        {
            int resultMinimumValue = Math.Min( numberN, numberExecutions );
            return Math.Min( resultMinimumValue, pendingInstructions );
        }
    }
}
