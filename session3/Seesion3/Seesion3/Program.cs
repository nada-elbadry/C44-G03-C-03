using System.Globalization;
using System.Net.NetworkInformation;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fractions And Discard
            //Floating point datatype{float,double,decimal,long}


            //float (single precision floating point): 4 bytes (32bits) approximatly 7 digits of precision
            //float myFloat = 10.123456789F;
            //Console.WriteLine(myFloat); // 10.123457


            //double(double precision floating point):8bytes(64 bits)approximatly 15-16 digits of precision
            //double myDouble = 10.123456789_123456789;
            //Console.WriteLine(myDouble);  // 10.123456789123457

            //decimal(high precision floating point):16 bytes(128 bits)approximate28-29digits of precision 
            //decimal myDecimal = 10.123456789_123456789_123456789m;
            //Console.WriteLine(myDecimal);  // Decimal: 10.123456789123456789123456789

            // long Number = 10_000_000_000; // Underscores are for readability(Discard)
            ////Console.WriteLine(Number); // 10000000000
            ////Console.WriteLine($"{Number:c}"); // $10,000,000,000.00
            ////								  // c => format specifier is used to format numbers as currency.

            //var cultureInfo = new CultureInfo("ar-SA");  // Arabic Saudi Arabia (Saudi Riyals)
            //Console.WriteLine(Number.ToString("c", cultureInfo));  // Saudi Riyals
            //													   // ر.س.100,000,000,000.00
            //CultureInfo culture = new CultureInfo("ar-SA");
            //Console.WriteLine(Number.ToString("c",culture));
            #endregion

            #region Casting 
            #region Implicit And Explicit Casting

            #region Example 01
            //int X = 10000; // 4 Bytes 
            //long Y = X; // 8 Bytes - Implicit Casting 
            //Console.WriteLine(Y); // 10000

            //long A = 10000;
            ////int B = A; // Invalid Implicitly 
            //int B = (int) A; // Explicit Casting Using Casting Operator
            //Console.WriteLine(B); // 10000


            //long C = 100000000000;
            //int D = (int) C; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //Console.WriteLine(D); // 1215752192 due to overflow

            //checked
            //{
            //    long E = 100000000000;
            //    int F = (int)E; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //    unchecked
            //    {
            //        Console.WriteLine(F); // System.OverflowException
            //    }
            //}


            // Protective code

            //long K = 12345678912;

            //if (K > int.MaxValue || K < int.MinValue)
            //{
            //	Console.WriteLine("Exception Will Be Throw Due To Overflow");
            //}
            //else
            //{
            //	int M = (int)K;
            //	Console.WriteLine(M);
            //}
            //// Exception Will Be Throw Due To Overflow

            //int M = K.GetType() == typeof(int) ? (int)K : 0;
            //Console.WriteLine(M); // 0 
            #endregion

            #region Example 02

            //int X = 10; // 4 bytes
            //decimal Y = X; // 16 Bytes  [Implicit Casting]
            //Console.WriteLine(Y); // 10



            //decimal K = 10.100M;
            //int M = (int)K; // Explicit Casting [May Cause Loss Of Data]
            //Console.WriteLine(M); // 10


            #endregion

            #endregion

            #region Convert 

            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name : ");
            //string? Name =  Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Salary : ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion

            #region Parse()
            //Console.WriteLine("Please Enter Your Data");

            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Salary : ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);
            #endregion

            #region TryParse

            //string number01 = "10";
            //int X01 = int.Parse(number01);
            //Console.WriteLine(X01); // 10

            //string number02 = "Aliaa";
            //int X02 = int.Parse(number02);
            //Console.WriteLine(X02); // System.FormatException


            //string number02 = "Aliaa";
            //bool IsParsed = int.TryParse(number02, out int X02); // doesn't throw exceptions
            //Console.WriteLine(IsParsed); // False 
            //Console.WriteLine(X02); // 0

            //string number03 = "10";
            //IsParsed = int.TryParse(number03, out int X03);
            //Console.WriteLine(IsParsed); // True 
            //Console.WriteLine(X03); // 10

            //Console.WriteLine("Please Enter Your Data");

            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int.TryParse(Console.ReadLine() ?? "0", out int Age);

            //Console.Write("Salary : ");
            //decimal.TryParse(Console.ReadLine() ?? "0", out decimal Salary);

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion
            #endregion

            #region Operators 

            #region Unary Operators [ ++ , -- ]
            //int X = 10;

            ////1. ++
            //// 1.1 PreFix [Increment and Then Print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11

            //// 1.2 PostFix [Print and Then Increment]
            //Console.WriteLine(X++); // 10 
            //Console.WriteLine(X); // 11


            ////2. --
            //// 2.1 PreFix [Decrement and Then Print]
            //Console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            //// 2.2 PostFix [Print and Then Decrement]
            //Console.WriteLine(X--); // 10 
            //Console.WriteLine(X); // 9
            #endregion

            #region Binary | Arithmetic Operators [+ , - , * , / , %]

            //int sumResult, subResult, mulResult, divResult, modResult;
            //int number01 = 6, number02 = 2;
            //sumResult = number01 + number02; // 8 
            //subResult = number01 - number02; // 4
            //mulResult = number01 * number02; // 12
            //divResult = number01 / number02; // 3
            //modResult = number01 % number02; // 0

            #endregion

            #region Assignment Operators [= , += , -= , *= , /= , %=]

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational | Comparsion Operators [== , != , < , > , <=, >=]
            //int X = 10, Y = 10;

            //Console.WriteLine(X == Y); // True
            //Console.WriteLine(X != Y); // False 
            //Console.WriteLine(X > Y); // False 
            //Console.WriteLine(X < Y); // False
            //Console.WriteLine(X >= Y); // True 
            //Console.WriteLine(X <= Y); // True

            #endregion

            #region Logical Operators [! , && , ||]
            //// Short Circuit
            //Console.WriteLine(!true); // False
            //Console.WriteLine(false && true); // False
            //Console.WriteLine(false || true); // True 


            //Console.WriteLine(4 < 5 && 7 < 9); // True
            //Console.WriteLine(4 < 5 && 7 > 9); // False
            //Console.WriteLine(4 > 5 && 7 < 9); // False

            #endregion

            #region BitWise Operator [& , | , ^ , ~ , << , >> ]
            //// Long Circuit
            //Console.WriteLine(false & true); // False
            //Console.WriteLine(true | false); // True 
            //Console.WriteLine(false ^ true); // True 

            //int X = 5 , Y = 3; // X = 0101 , Y = 0011
            //Console.WriteLine(X & Y);  // 1 (0101 & 0011 = 0001)
            //Console.WriteLine(X | Y);  // 7 (0101 | 0011 = 0111)
            //Console.WriteLine(X ^ Y);  // 6 (0101 ^ 0011 = 0110)
            //Console.WriteLine(~X);     // -6 (complement of 0101 is 1010)
            //Console.WriteLine(X << 1); // 10 (1010)  
            //Console.WriteLine(X >> 1); // 2  (0010)
            #endregion

            #region Terany Operator [Conditional Operator] [?:]

            //int X = 10, Y = 5;

            //string Message = X > Y ? "X > Y" : "X < Y";

            //Console.WriteLine(Message);
            #endregion

            #region Operators Priority and Associativity

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int Result;

            //Result = (a + b) * c / d; // ( 20 + 15 ) * 10 / 5 = 70
            //Result = ((a + b) * c) / d; // (( 20 + 15 ) * 10 ) / 5 = 70
            //Result = (a + b) * (c / d); // ( 20 + 15 ) * ( 10 / 5 ) = 70
            //Result = a + (b * c) / d; // 20 + ( 15 * 10 ) / 5 = 50

            #endregion
            #endregion

            #region String Formatting 
            //// Equation : 10 + 5 = 15
            //int X = 10, Y = 5 , result;
            //result = X + Y;
            //string message;
            //// 1. String Interpolation
            //message = $"Equation : {X} + {Y} = {result}";
            //Console.WriteLine(message);

            //// 2. String.Format Method
            //message = string.Format("Equation : {0} + {1} = {2}" , X , Y ,result);
            //Console.WriteLine(message);

            //// 3. Composite Formatting
            //Console.WriteLine("Equation :x {0} + {1} = {2}" , X , Y , result);

            //// 4. String Concatenation
            //message =  "Equation : " + X + " + " + Y + " = " + result;
            //Console.WriteLine(message);


            //// File Path 
            //// D:\Cycle 43 .Net\Group 06\C#\Session 03\Day03 Solution\Demo\Demo.csproj

            //string filePath = "D:\\Cycle 43 .Net\\Group 06\\C#\\Session 03\\Day03 Solution\\Demo\\Demo.csproj";
            //filePath = @"D:\Cycle 43 .Net\Group 06\C#\Session 03\Day03 Solution\Demo\Demo.csproj";
            //Console.WriteLine(filePath);

            //Console.WriteLine("Aliaa\tTarek\nBackend Instructor");
            ////Aliaa   Tarek
            ////Backend Instructor
            #endregion

            #region Control Statements 
            #region 1. Conditional Statements

            #region Example 01 [Year Quarter] - [If,Switch With Numeric type using Constant Pattern]
            //Console.Write("Please Enter A Month Number Existed in 1st Quarter : ");

            //int.TryParse(Console.ReadLine(), out int monthNumber);

            #region if else
            //if (monthNumber == 1)
            //	Console.WriteLine("Hello January");
            //else if (monthNumber == 2)
            //	Console.WriteLine("Hello February");
            //else if (monthNumber == 3)
            //	Console.WriteLine("Hello March");
            //else
            //	Console.WriteLine("The Entered Month Number is not a Valid Month At First Quarter"); 
            #endregion

            #region switch 
            // Jump Table 
            //switch (monthNumber)
            //{
            //	case 1:
            //		Console.WriteLine("Hello Jan");
            //		break;
            //	case 2:
            //		Console.WriteLine("Hello Feb");
            //		break;
            //	case 3:
            //		Console.WriteLine("Hello March");
            //		break;
            //	default:
            //		Console.WriteLine("The Entered Month Number is not a Valid Month At First Quarter");
            //		break;
            //}
            #endregion

            //Console.ReadKey();
            #endregion

            #region Example 02 [Student Age] - [If,Switch With Numeric type using Relational Pattern]
            /// Age is greater than 22 => Student Age Is greater than 22 
            /// Age is Less than 22 => Student Age Is Less than 22 
            /// Age is 22 => Student Age is 22 

            //Console.Write("Please Enter Student Age : ");
            //int.TryParse(Console.ReadLine(), out int age );

            #region if else
            //if (age > 22)
            //	Console.WriteLine("Student Age Is greater than 22 ");
            //else if (age < 22)
            //	Console.WriteLine("Student Age Is less than 22 ");
            //else
            //	Console.WriteLine("Student Age Is 22 "); 
            #endregion

            #region switch
            // No Jump Table Will be Created 
            //switch( age )
            //{
            //	case > 22:
            //		Console.WriteLine("Student Age Is greater than 22 ");
            //		break;
            //	case < 22:
            //		Console.WriteLine("Student Age Is less than 22 ");
            //		break;
            //	default:
            //		Console.WriteLine("Student Age Is 22");
            //		break;
            //}
            #endregion


            #endregion

            #region Example 03 [Student Name] - [If,Switch With String type]
            /// name = Omar => Hello Omar 
            /// name = May => Hello May 
            /// name = Aliaa => Hello Aliaa 

            //Console.Write("Enter Student Name : ");
            //string name = Console.ReadLine() ?? "No Name Entered";

            #region if else 
            //if(name == "Omar")
            //	Console.WriteLine("Hello Omar");
            //else if(name == "May")
            //	Console.WriteLine("Hello May");
            //else if(name == "Aliaa")
            //	Console.WriteLine("Hello Aliaa");
            #endregion
            #region switch 
            //// No Jump Table Will Be Created
            //// Compiler will generate a sequence of string comparisons
            //switch (name)
            //{
            //	case "Omar":
            //		Console.WriteLine("Hello Omar");
            //		break;
            //	case "May":
            //		Console.WriteLine("Hello May");
            //		break;
            //	case "Aliaa":
            //		Console.WriteLine("Hello Aliaa");
            //		break;
            //}
            #endregion
            #endregion

            #region Example 04 [Budget] - [Switch With Goto]
            /// Budget is 1000 => Option 01
            /// Budget is 2000 => Option 01 , Option 02
            /// Budget is 3000 => Option 01 , Option 02 , Option 03

            //Console.Write("Please Enter Your Budget : ");
            //int.TryParse(Console.ReadLine(), out int Budget);

            //switch(Budget)
            //{
            //	case 1000:
            //		Console.WriteLine("Option 01");
            //		break;
            //	case 2000:
            //		Console.WriteLine("Option 02");
            //		goto case 1000;
            //		//Console.WriteLine("Option 01");
            //		//break;
            //	case 3000:
            //		Console.WriteLine("Option 03");
            //		goto case 2000;
            //		//Console.WriteLine("Option 02");
            //		//Console.WriteLine("Option 01");
            //		//break;
            //}

            #endregion

            #region Goto 

            //Retry:
            //Console.Write("Please Enter Your Name : ");
            //string name = Console.ReadLine();

            //if(name == "Aliaa")
            //	goto Retry;
            //else
            //	Console.WriteLine($"Name is {name}");

            #endregion



            #endregion
            #endregion

            sing hello1;
class Program
        {
            static void Main(string[] args)
            {
                #region error types
                //Console.WriteLine("Hello, World!");
                //int x;
                //Console.WriteLine(x);

                //int x = 5;
                //int y = 0;
                //Console.WriteLine(x/y);
                //int x = Sum(5, 10);
                //Console.WriteLine(x);
                #endregion
                //Declare variable x
                //int x;
                /*
                 sdcv
                sdv
                sdc
                 */

                #region  Declare Variable
                //int static;
                //int x=5;
                //Console.WriteLine(x);
                //x = 7;
                //x = "Ahmed";//inva;id
                // string Name = "test";
                #endregion
                /*
                 common type system (CTS)
                 common language specification (CLS)
                */
                #region Datatype
                #region  Value Type
                int x;
                //CLR allocate 4 unintialized bytes in stack
                x = 4;
                //4 bYTES = 4
                Int32 y = 9;
                //CLR allocate 4 intialized Bytes in stack = 9
                y = x;
                Console.WriteLine(x);
                Console.WriteLine(y);
                x++;
                Console.WriteLine(x);
                Console.WriteLine(y);
                #endregion
                #region  Ref Type
                hello1.Point P01;
                //Declare For Reference  of  Type Point "P1" Reference to Null
                //4 Bytes Allocated in Stack for Pointer| Reference
                //0 Bytes Allocated in Heap
                P01 = new hello1.Point();
                //1.Allocated Required Bytes at Heap
                // 2. Initialize Allocated Bytes Of Object With Default Value
                // 3. Call User Defined Constructor (If Exist)
                // 4. Assign Reference (P1) To Allocated Object
                hello1.Point P02 = new hello1.Point();//unrichable object
                P02 = P01;

                #endregion
                #endregion
                #region Object
                //x = 5;
                //Console.WriteLine(x.ToString());
                Console.WriteLine(P01.ToString());
                Console.WriteLine(P01.GetHashCode());
                Console.WriteLine(P01.GetType());
                object obj;
                obj = 1;
                obj = 1.2;
                obj = "Ahmed";
                obj = true;
                Console.WriteLine(obj);
                #endregion
            }
            #region function 
            //ctrl+k ctrl+s
            /// <summary>
            /// sum two number
            /// </summary>
            /// <param name="x">firest number</param>
            /// <param name="y"> second number</param>
            /// <returns> sum of <paramref name="x"/>and<paramref name="y"/></returns>
            //static int Sum(int x, int y)
            //{
            //    return x - y;
            //}
            #endregion
            ///BCL       C# Keyword
            ///Byte        byte
            ///Int16       Short
            ///Int32       int
            ///Int64       Long
            ///Single      float
            ///Double      double
            ///Decimal     decimal
            ///String      string
            ///Char        char
            ///
        }
    }
    }
}
