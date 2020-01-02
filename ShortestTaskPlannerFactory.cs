﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ShortestTaskPlannerFactory : IFactory<IPlanner>
    {
        public IPlanner Create()
        {
            return new Planner( new ShortestTaskFirstProcessorTaskVerifier() );
        }
    }
}
