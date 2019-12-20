using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OptionMenuFactory : IOptionsFactory<IPlannerTasks>
    {
        public IPlannerTasks OptionFactory(string option)
        {
            var optionMenu = new OptionsMenu().MenuOption(option);

            return new PlannerFactory().OptionFactory(optionMenu);
        }
    }
}
