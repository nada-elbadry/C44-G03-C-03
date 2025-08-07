using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    [Flags]
    internal enum Permissions:byte//8 bit
    {
         Delete=1,
         Execute=2,
         Read=4,
         Write=8
    }
}
