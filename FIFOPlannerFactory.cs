using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class FIFOPlannerFactory : IFactory<IPlanner>
    {
        public IPlanner Create()
        {
            return new PlannerTasks(new FIFOProcessorTaskVerifier());
        }

    }
}
