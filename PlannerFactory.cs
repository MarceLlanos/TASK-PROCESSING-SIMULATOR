using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PlannerFactory : IOptionsFactory<IPlannerTasks>
    {
        public IPlannerTasks Option(string planneSort)
        {
            switch (planneSort)
            {
                case "FIFO":
                    return new FIFOPlannerFactory().Create();

                case "Priority Based":
                    return new PriorityBasePlannerFactory().Create();

                case "Shortest Task First":
                    return new ShortestTaskPlannerFactory().Create();

                case "Round Robin":
                    return new RoundRobinPlannerFactory().Create();

                case "Round Robin - Priority Based":
                    return new PriorityBasedRoundRobinFactory().Create();

                default:
                    return new FIFOPlannerFactory().Create();
            }
        }
    }
}
