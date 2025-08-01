using session_5;

///into namespace:
///Class
///Struct
///interface
///Enum
internal class Program
{
    ///into class:
    ///1.Methodes
    ///1.1Class Member Methods[Static Method]
    ///1.2Object Member Method[Non Static Methods]
    #region Function
    #region Function Prototype
    //public static void PrintShape(string pattern = "+", int count = 3)
    //{
    //    for (int i = 0; i <= count; i++)
    //    {
    //        Console.WriteLine(pattern);
    //    }
    //}

    #endregion



    #region Function Parameters [Value Type]
    #region Passing By Value
    //public static void Swap(int x, int y)
    //{
    //    int Temp = x;
    //    x = y;
    //    y = Temp;
    //}

    #endregion
    #region Passing By ref
    //public static void Swap(ref int x, ref int y)
    //{
    //    int Temp = x;
    //    x = y;
    //    y = Temp;
    //}

    #endregion
    #endregion
    #region Function Parameters [Reference Type]
    #region Examble01
    #region Passing By Value

    //public static int SumArray(int[]arr)//arr=numbers=Adress
    //{

    //    int sum = 0;
    //    if (arr is not null)
    //    {
    //        arr[0] = 100;
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            sum += arr[i];//Accumulate
    //        }
    //    }
    //    return sum;
    //} 
    #endregion

    #endregion
    #region Examble01
    #region Passing by ref

    //    public static int SumArray(ref int[] arr)//arr=numbers=Adress
    //{

    //    int sum = 0;
    //    if (arr is not null)
    //    {
    //        arr[0] = 100;
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            sum += arr[i];//Accumulate
    //        }
    //    }
    //    return sum;
    //} 
    #endregion
    #region Examble02
    #region passing by value
    //public static int SumArray(int[] arr)//arr=numbers=Coppy of Adress
    //{

    //    int sum = 0;
    //    if (arr is not null)
    //    {
    //        arr = [10, 20, 30, 40];
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            sum += arr[i];//Accumulate
    //        }
    //    }
    //    return sum;
    //}
    #endregion
    #region Passing By Ref
    //public static int SumArray(ref int[] arr)//arr=numbers=Adress
    //{

    //    int sum = 0;
    //    if (arr is not null)
    //    {
    //        arr = [10,20,30,40];
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            sum += arr[i];//Accumulate
    //        }
    //    }
    //    return sum;
    //}
    #endregion
    #endregion
    #endregion

    #endregion
    #region Function Parameters [ Passing by out]
    //public static DataToReturn SumSub(int x , int y)
    //{
    //    int Sum = x+ y;
    //    int Sub = x-y;
    //    //return new int[]{Sum, Sub};//Return Array 
    //    //return [Sum,Sub];//ShortHandle
    //    return new DataToReturn() { sub = Sub ,sum=Sum};//Return Object From Class
    //}
    //public static void SumSub(int x, int y)
    //{
    //    int Sum = x + y;
    //    int Sub = x - y;
    //    return new {Sum, Sub};  //Return  anonimous Object
    //}

    //public static void SumSub(int x, int y, out int Sum, out int Sub)
    //{
    //    Sum = x + y;
    //    Sub = x - y;
    //}
    #endregion
    #region Function Parameters [Params]
    //public static int SumArray(int X, params int[]Array)//,Int Y Invalid 
    //{
    //    int sum = 0;
    //    if (Array is not null)
    //    {
    //        for (int i = 0; i < Array.Length; i++)
    //        {
    //            sum += Array[i]; 
    //        }
    //    }
    //    return sum;
    //}

    //public static void Concat( params ReadOnlySpan<Task> items)//مش فاهمة
    //{
    //    for(int i = 0;i < items.Length;i++)
    //    {
    //        Console.Write($"{items[i]}  ");
    //    }
    //}
    #endregion
    //Entry Point
    static void Main(string[] args)
    {


        #region Arrays
        #region 1D Array

        #region Example01
        //int[] numbers;
        //Declare For Reference From Type Array 'numbers'
        //Reference 'numbers' Is Referring To Null
        //CLR Will Allocate 4 Bytes At Stack For Reference
        //0 Bytes Allocate At Heap

        //Console.WriteLine(numbers[0]);//Invalid
        //numbers = new int[3] {1,2,3};
        //Console.WriteLine($"Size Of Array{numbers.Length},Dimension Of Array={numbers.Rank}");
        //for ( int i = 0; i < numbers.Length; i++ )
        //    Console.WriteLine(numbers[i]);

        //foreach ( int item in numbers )
        //    Console.WriteLine(item);
        //CLR Will Allocate Required Bytes At Heap [4*3]=12 Bytes
        //Initialize Allocated Bytes With Default Values [0,0,0]
        //Console.WriteLine(numbers[0]);
        //Console.WriteLine(numbers[1]);
        //Console.WriteLine(numbers[2]);

        //numbers[0] = 1;
        //numbers[1] = 2;
        //numbers[2] = 3;

        //Console.WriteLine(numbers[0]);
        //Console.WriteLine(numbers[1]);
        //Console.WriteLine(numbers[2]); 
        #endregion

        #region Array  Creation Way 

        //int[] number01 = new int[3];
        //int[] number02 = new int[] {1,2,3};
        //int[] number03 = { 1, 2, 3 }; 
        //int[]number04= { 1, 2, 3 };//Collection Expression [.NET12 C#8] 
        #endregion
        #endregion
        #region 2D Array (Rectangular)

        #region Examble 01
        //int[,] Marks = new int[2, 5] { { 100, 50, 90, 30, 40 }, { 20, 10, 60, 70, 80 } };
        ////CLR Will Allocate 40 Bytes At Heap Intialized With Default Value [0]
        //Console.WriteLine($"Size Of Array={Marks.Length},D ={Marks.Rank}");
        ////Take Data From User
        //for (int i = 0; i < Marks.GetLength(0); i++)
        //{
        //    Console.WriteLine($"Grades Of Students Number ={i + 1}");
        //    for (int j = 0; j < Marks.GetLength(1);)
        //    {
        //        Console.Write($"Subjects No {j + 1}:");
        //        bool IsParsed = int.TryParse(Console.ReadLine(), out Marks[i, j]);
        //        if (IsParsed)
        //        { j++; }
        //    }
        //    Console.WriteLine("=============================");
        //}
        //Console.Clear();
        ////Print Elements In Array
        //for (int i = 0; i < Marks.GetLength(0); i++)
        //{
        //    Console.WriteLine($"Grades Of Students Number ={i + 1}");
        //    for (int j = 0; j < Marks.GetLength(1); j++)
        //        Console.WriteLine($"Marks Of Sub No {j + 1}={Marks[i, j]}");


        //    Console.WriteLine("=============================");
        //}
        #endregion
        #region Examble 02 [Using One Loop]
        //int[,] Marks = new int[2, 4];
        //for (int i = 0; i < Marks.Length;)
        //{
        //  bool IsParsed= int.TryParse(Console.ReadLine(), out int StudentMark);
        //    if (IsParsed)
        //    {
        //        Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)] = StudentMark;
        //        i++;
        //    }
        //    //i=IsParsed ? i++ : i;//wrong ????
        //    //i=IsParsed ? ++i : i;

        //}
        ////Print
        //for(int i = 0;i < Marks.Length;i++)
        //{
        //    Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);
        //}
        #endregion
        #endregion
        #region Jagged Array
        //int[][] JaggedArray = new int[3][];
        //JaggedArray[0] = new int[4];
        //JaggedArray[1] = new int[] {10,20 };
        //JaggedArray[2] = [30, 40, 50];
        #endregion
        #region Array Methods
        #region Class Member Methods
        //int[] numbers = { 5, 3,4,1,2,4};

        //Array.Sort(numbers);
        //Array.Reverse(numbers);
        //Array.Clear(numbers, 0, numbers.Length);
        //Console.WriteLine(Array.IndexOf(numbers, numbers[0]));
        //Console.WriteLine(Array.LastIndexOf(numbers, numbers[1]));
        //Array.Resize(ref numbers, 10);
        //foreach (int item in numbers)
        //Console.WriteLine(item);
        //int[] Arr01 = { 1, 2, 3, 4, 5 };
        //int[] Arr02 = new int[4];
        //Array.Copy(Arr01, Arr02, 4);
        //Array.ConstrainedCopy(Arr01, 1, Arr02, 1, 2);
        //Console.ReadKey();

        #endregion
        #region Object Member Method
        //int[] Numbers = { 1, 2, 3, 4, 5 };
        //Numbers.GetLength(0);//==Console.WriteLine(Numbers.Length);
        //int Element=(int)Numbers.GetValue(1);//==Element = Numbers[1];
        //Numbers[0] = Element = 100;
        //Numbers.SetValue(100, 1);
        #endregion
        #endregion
        #endregion

        #region Function Prototype
        //Console.WriteLine("Welcome Aliaa \t Hello Amr");
        //Console.WriteLine("Welcome Aliaa \n Hello Amr");
        //Console.WriteLine("Welcome Aliaa \r Hello Amr");
        //Console.WriteLine("Welcome Aliaa \b Hello Amr");
        //Console.WriteLine("Hello \\Aliaa");
        //Console.WriteLine(@"Hello \Aliaa \n");
        //int number = 10;
        //Console.WriteLine($"Hello {number}{{World}}");
        //Console.WriteLine($@"Hello {number}{{World}}");


        //PrintShape("*", 5);
        //PrintShape("/", 7);//Passing Parameters By Order
        //PrintShape(count: 10, pattern: "==");//Passing Parameters By Name
        //PrintShape();//Using Default Value
        //PrintShape(pattern:"/*\\");
        //PrintShape(pattern:@"/*\"); 
        #endregion

        #region Function Parameters [Value Type]
        #region Passing By Value
        //int A = 10; int B = 5;
        //Console.WriteLine($"A={A}");
        //Console.WriteLine($"B={B}");
        //Swap(A, B);//Passing By Value
        //Console.WriteLine("After Swapping");
        //Console.WriteLine($"A={A}");
        //Console.WriteLine($"B={B}"); 
        #endregion
        #region Passing by ref
        //int A = 10; int B = 5;
        //Console.WriteLine($"A={A}");
        //Console.WriteLine($"B={B}");
        //Swap(ref A, ref B);//Passing By Value
        //Console.WriteLine("After Swapping");
        //Console.WriteLine($"A={A}");
        //Console.WriteLine($"B={B}");
        #endregion
        #region Function Parameters [Reference Type]
        #region Examble01
        #region Passing by value
        //int[] numbers = { 1, 2, 3 };
        //Console.WriteLine(numbers[0]);
        //int Result = SumArray(numbers);//Passin By Value[Addresss]
        //Console.WriteLine($"Result={Result}");
        //Console.WriteLine(numbers[0]); 
        #endregion
        #region  Passing By ref
        //int[] numbers = { 1, 2, 3 };
        //Console.WriteLine(numbers[0]);
        //int Result = SumArray(ref numbers);//Passin By Reference[Reference of array :numbers ]
        //Console.WriteLine($"Result={Result}");
        //Console.WriteLine(numbers[0]);
        #endregion
        #endregion
        #region Examble02
        #region passing by value
        // int[] numbers = { 1, 2, 3 };
        // Console.WriteLine($"Numbers[0]={numbers[0]}");//1
        //int Result=SumArray(numbers);//Passing By Value[Adress]
        // Console.WriteLine($"Sum={Result}");
        // Console.WriteLine($"Numbers[0]={numbers[0]}");
        #endregion
        #region Passing By ref
        //int[] numbers = { 1, 2, 3 };
        //Console.WriteLine(numbers[0]);
        //int Result = SumArray(ref numbers);//Passin By Reference[Reference of array[numbers] ]
        //Console.WriteLine($"Result={Result}");
        //Console.WriteLine(numbers[0]);
        #endregion
        #endregion
        #endregion
        #endregion
        #region Function Parameters [ Passing by out]
        //int a = 10 , b= 3,SumResult,SubResult;
        //SumSub(a,b,out SumResult,out SubResult);//Passing by Out
        //Console.WriteLine($"Sum Result ={SumResult}");
        //Console.WriteLine($"Sub Result = {SumResult}");
        #endregion

        #region Function Parameters [Params]

        //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //int First = 1;
        //int Second = 2;
        //int Third = 3;
        //int Result =SumArray(First,Second,Third,4,5,6);//C# will Convert it An Array Internally 
        //Console.WriteLine(Result);
        //string Message = string.Format("Hello {0} Your Age Is {1}", "Aliaa", 25);
        #region With C#13
        //Concat<object>("Hello Nada","Welcome To Route",DateTime.Now,25);
        #endregion
        #endregion

    }
}
#endregion