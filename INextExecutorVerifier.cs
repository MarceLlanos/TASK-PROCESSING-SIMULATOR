using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    interface IFactory
    {
        bool VerifyNextExecute(int firstTask, int secondTask);
    }
}
