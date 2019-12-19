﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PriorityBasePlannerrFactory : IFactory<IPlannerTasks>
    {
        public IPlannerTasks Create()
        {
            return new PlannerTasks(new PriorityBasedNextVerifier());
        }
    }
}