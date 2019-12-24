using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OptionMenuFactory : IOptionsFactory<IPlannerTasks>
    {
        public IPlannerTasks Option(string option)
        {
            var optionMenu = new OptionsMenu().Option(option);

            return new PlannerFactory().Option(optionMenu);
        }
    }
}
