﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class PunchCommand : Command
    {
        public override string Execute()
        {
            return "Punch";
        }
    }
}
