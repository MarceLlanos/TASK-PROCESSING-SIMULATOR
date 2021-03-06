﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class AlgorithmMenuFactory : IMenuFactory<IPlanner>
    {
        public IPlanner CreateMenu(string option)
        {
            var optionMenu = new NumericMenu().CreateMenu(option);

            return new PlannerFactory().CreateMenu(optionMenu);
        }
    }
}
