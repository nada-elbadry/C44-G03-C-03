using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssigment_OOP_01
{
    [Flags]
    enum Permission
    {
        None = 0,
        Read = 1 << 0,     // 1 ==> 2⁰ 
        Write = 1 << 1,    // 2 ==> 2¹
        Delete = 1 << 2,   // 4 
        Execute = 1 << 3 ,  // 8
    }
}
