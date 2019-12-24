using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Minimo : IMinimo
    {
        public int IsMinimo(int nValue, int executeValue, int pendingInstructions)
        {
            int result = Math.Min(nValue,executeValue);
            result = Math.Min(result, pendingInstructions);

            return result;
        }
    }
}
