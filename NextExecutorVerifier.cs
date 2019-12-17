using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class NextExecutorVerifier : IFactory
    {
        public bool VerifyNextExecute(int firstTask, int secondTask)
        {
            bool result = false;

            if (firstTask < secondTask)
            {
                result = true;
            }

            return result;
        }
    }
}
