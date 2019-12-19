using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OptionsFactory : IOptionsFactory
    {
        IQueueTask queueTask;

        public OptionsFactory(IQueueTask queueTask)
        {
            this.queueTask = queueTask;
        }
        public IPlannerTasks PlanneTask(string planneSort)
        {
            switch (planneSort)
            {
                case "FIFO":
                    return new FIFOPlannerFactory().Create();

                case "Priority Based":
                    return new PriorityBasePlannerrFactory().Create();

                case "Shortest Task First":
                    return new ShortestTaskPlannerFactory().Create();

                default:
                    return new FIFOPlannerFactory().Create();
            }
        }
    }
}
