using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03
{
    internal enum Security:byte
    {
        Guest=1,
        DBA=2,
        Developer=4,
        Secretary=8
    }
}
