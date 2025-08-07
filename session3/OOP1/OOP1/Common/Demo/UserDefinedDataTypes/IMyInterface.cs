using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal interface IMyInterface//or public
    {
        //What you can write inside interface?
        //1. Signature For Property=> C#7
        public int MyProperty { get; set; }
        //2. Signature For Method => C#7
        public void Myfunction();
        //3. Default Implement Methods => C#8
        private void MyFunction02()
        {
            Console.WriteLine(MyProperty);
        }
        //Access Modifier Allowed Inside Interface:
        //Default Public  
    }
}
