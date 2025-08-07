using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public class TypeA
    {
       private int x;
       internal int y;
       public int z;
        public TypeA()
        {
            x = 1;//private Accessable Within Its Scope
            y = 2;//internal Accessable Within Its Scope
            z = 3;//public Accessable Within Its Scope
        }
    }
}
