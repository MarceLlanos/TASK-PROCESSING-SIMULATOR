﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    interface IMinimum
    {
        int GetMinimum( int numberN, int numberOfExecutions, int pendingInstructions);
    }
}
