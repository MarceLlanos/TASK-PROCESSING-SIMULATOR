using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OrchestratorFactory : IOrchestratorFactory
    {
        public IOrchestrator CreateOrchestra(string algorithm)
        {
            var optionPlanner = new AlgorithmMenuFactory().CreateMenu(algorithm);
            var processorTask = new ProcessorTask();
            var roundRobinProcessorTask = new RoundRobinProcessorTask();

            if (algorithm == "4")
            {
                return new Orchestrator(optionPlanner, roundRobinProcessorTask);
            }

            return new Orchestrator(optionPlanner, processorTask);
        }
    }
}
