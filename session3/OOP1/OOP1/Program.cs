using System.ComponentModel.Design;

namespace OOP1
{
    
    internal class Program
    {
     
        static void Main(string[] args)
        {
            #region Boxing-Unboxing
            #region Boxing[Value Type =>Reference Type]Safe
            //int x = 100;
            //object obj = x;//Boxing
            //               //Implicity
            //               //Take Coppy From Value and Wrapping The Value in An Object
            //obj = 12.3;//Casting From Value Type [Double] =>  To Reference Type [Object]--->Boxing
            //obj = 'A';//Casting From Value Type [Char] =>  To Reference Type [Object]--->Boxing
            //obj = 12.12f;//Casting From Value Type [float] =>  To Reference Type [Object]--->Boxing
            ////Safe Casting
            //Console.WriteLine(obj);

            #endregion

            #region Unboxing[Refrence Type => Value Type]unsafe

            //object obj = "Aliaa";
            //obj = 10;
            //obj = new int[] {1,2,3};
            //int X =(int)obj;//Unboxing - Unsafe - Explicity
            //Console.WriteLine(X);
            #endregion
            #endregion

            #region Nullable Value Types
            #region Examble01
            ////int x = 10;
            ////x = null;//invalid

            //Nullable<int> Y = 10;
            //Y=null;
            ////Y can hold Int value+ null

            //int? Z = 100;
            //Z = null; 
            #endregion

            #region Examble02
            //int x = 10;
            // int? y = x;//Valid -Implicitly Casting

            /// x can hold int values
            /// y can hold int values + null

            // int? A = 10;
            // int B =(int) A;//Valid - Explicitly Casting - Unsafe

            // Console.WriteLine(B);

            //int? A = 10;
            //int B;
            //if (A is not null)
            //    B = (int)A;
            //==============
            //else
            //    B = 0;
            //if(A.HasValue)
            //    B=A.Value;
            // else
            //  B = 0;

            //===============
            // B=A.HasValue?A.Value:0;
            //========================
            // B = A ?? 0;
            //========================
            // B = A.GetValueOrDefault();

            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"{B}");

            #endregion

            #endregion

            #region Nullable Reference Type
            //string name001 = null!;//null forgiving operator
            //Console.WriteLine(name001);

            //string? name02 = null;//Compiler inhancment
            //Console.WriteLine(name02);
#nullable disable
#nullable enable

            #endregion

            #region Null-Conditional | Propagation Operator


            //int[] numbers = null;

            //int arrayLength = numbers?.Length??0;//null collesing operators

            //int? arrayLength02= numbers.Length;

            //if (numbers is not null)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
           // else
           //{ 
           //     //Need Addional Actions ToBe Executed
           //}

                //for (int i = 0; i < numbers?.Length; i++)//short_circuit
                //{
                //    Console.WriteLine(numbers[i]);
                //}
                //numbers?.Length
                //numbers is null => null
                //numbers Value => numbers.Length
                #endregion



            }
    }
}
