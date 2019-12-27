using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OptionMenuFactory : IOptionsFactory<IPlanner>
    {
        public IPlanner CreateOption(string option)
        {
            var optionMenu = new OptionsMenu().CreateOption(option);

            return new PlannerFactory().CreateOption(optionMenu);
        }
    }
}
