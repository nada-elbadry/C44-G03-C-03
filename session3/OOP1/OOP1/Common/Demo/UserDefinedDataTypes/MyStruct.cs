using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal struct MyStruct
    {
        // struct is value type
        //struct only allow 3 access modifier : public , private , internal

        //What You Can Write Inside struct?
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
    }
}
