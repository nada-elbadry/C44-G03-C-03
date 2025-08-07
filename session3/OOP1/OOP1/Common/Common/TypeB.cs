using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
        public TypeB()
        {
            TypeA typeA = new TypeA();
            //typeA.X=1;//Invalid //Private is Acessable Within Its Scope Only
            typeA.y = 1;//Valid //internal Accessable Within Its Scope And in Same Project
            typeA.z = 4;//Valid//Public  Accessable Within Its Scope And in Same Project
        }
    }
}
