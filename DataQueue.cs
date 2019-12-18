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

        public DataQueue(int nValue, int executeValue)
        {
            this.nValue = nValue;
            this.executeValue = executeValue;
        }

        public int GetExecuteValue()
        {
            return executeValue;
        }

        public int GetNValue()
        {
            return nValue;
        }

        public void SetExecuteValue(int executeValue)
        {
            this.executeValue = executeValue;
        }
    }
}
