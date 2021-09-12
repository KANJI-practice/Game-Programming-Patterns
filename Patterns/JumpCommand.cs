using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class JumpCommand:Command
    {
        public override string Execute()
        {
            return "Jump";
        }
    }
}
