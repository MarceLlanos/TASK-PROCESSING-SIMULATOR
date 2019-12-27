using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Minimum : IMinimum
    {
        public int GetMinimum( int numberN, int numberExecutions, int pendingInstructions )
        {
            int resultMinimumValue = Math.Min( numberN, numberExecutions );
            resultMinimumValue = Math.Min( resultMinimumValue, pendingInstructions );

            return resultMinimumValue;
        }
    }
}
