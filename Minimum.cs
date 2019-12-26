using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Minimum : IMinimum
    {
        public int GetMinimum(int nValue, int executeValue, int pendingInstructions)
        {
            int result = Math.Min(nValue,executeValue);
            result = Math.Min(result, pendingInstructions);

            return result;
        }
    }
}
