using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal class MyClasscs
    {
        //What You Can Write Inside Class?
        //1. Attributes [Fields]->Member Variable
        int myAttributes;//Attribute with Private Access Modifiern [Default]
        //2. Functions[Constructor,Getter Setter , Method]
        internal void MyFunction()
        {
            Console.WriteLine(myAttributes);
        }
        //3. Properties[Full Property ,Automatic Property , Indexer]
        public int MyProperty { get; set; }
        //4. Events

        // Class Allow all access modifier {6}
    }
}
