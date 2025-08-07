using System.Security.Cryptography.X509Certificates;

internal class Program
{
    #region 1.Value Type: Pass by Value vs by Reference
    // // 1a. Value type by value
    //public static void ChangeValue(int x)
    // {
    //     x = 50;
    // }

    // // 1b. Value type by reference
    // public static void ChangeValueRef(ref int x)
    // {
    //     x = 99;
    // }
    // public static void ModifyByValue(int number)
    // {
    //     number = number * 2;
    //     Console.WriteLine($"Inside ModifyByValue: {number}");
    // }
    // // Method that takes value type by reference
    // public static void ModifyByReference(ref int number)
    // {
    //     number = number * 2;
    //     Console.WriteLine($"Inside ModifyByReference: {number}");
    // } 
    #endregion
    #region 2.Reference Type: Pass by Value vs by Reference
    //1b reference type by value
    //public static void ModifyArray(int[] arr)
    // {
    //     arr[0] = 42;
    // }

    // // 2b. Reference type by reference
    // public static void ChangeArray(ref int[] arr)
    // {
    //     arr = new int[10];
    // }
    #endregion

    #region 3. Function with 4 Params - Sum and Subtract
    //// 3. Function with 4 parameters, returning sum and subtract
    //static string SumAndSubtract(int a, int b, out int sum, out int diff)
    //{
    //    sum = a + b;
    //    diff = a - b;
    //    return "Processed.";
    //}

    #endregion

    #region 4. Sum of Digits Function
    //public static int SumOfDigits(int number)
    //{
    //    int sum = 0;
    //    while (number != 0)
    //    {
    //        sum += number % 10; // Get the last digit
    //        number /= 10;       // Remove the last digit
    //    }
    //    return sum;
    //}

    #endregion

    #region  5. IsPrime Function
    //static bool IsPrime(int n)
    //{
    //    if (n <= 1) return false;
    //    for (int i = 2; i <= Math.Sqrt(n); i++)
    //        if (n % i == 0) return false;
    //    return true;
    //}

    #endregion


    #region  6. MinMax with ref parameters
    //public static void MinMaxArray(int[] arr, out int min, out int max)
    // {
    //     min = max = arr[0];
    //     foreach (var num in arr)
    //     {
    //         if (num < min)
    //                    min = num;
    //         if (num > max) 
    //                    max = num;
    //     }
    // }

    #endregion

    #region  7. Iterative factorial
    //public static long Factorial(int n)
    //{
    //    long result = 1;
    //    for (int i = 2; i <= n; i++)
    //        result *= i;
    //    return result;
    //}
    #endregion


    #region  8. Change character at specific position
    //public static string ChangeChar(string input, int pos, char replacement)
    //{
    //    if (pos < 0 || pos >= input.Length)
    //        return input;
    //    return input.Substring(0, pos) + replacement + input.Substring(pos + 1);
    //} 
    #endregion
    public static void Main(string[] args)
    {
        #region 1. Value Type: Pass by Value vs by Reference
        ///When a value type is passed by value, a copy of the variable's value is passed to the method
        ///Changes made to the parameter inside the method do not affect the original variable{default behavior}
        ///When a value type is passed by reference the method receives a reference to the original variable.
        ///Changes made to the parameter inside the method affect the original variable.
        //int a = 10;
        //Console.WriteLine($"Before: a = {a}");
        //ChangeValue(a); // pass by value
        //Console.WriteLine($"After pass-by-value: a = {a}");
        //ChangeValueRef(ref a); // pass by reference
        //Console.WriteLine($"After pass-by-reference: a = {a}");
        //int value1 = 10;
        //int value2 = 10;

        //Console.WriteLine($"Before calling methods:");
        //Console.WriteLine($"value1 = {value1}, value2 = {value2}");

        //// Pass by value
        //ModifyByValue(value1);
        //Console.WriteLine($"After ModifyByValue: value1 = {value1}");

        //// Pass by reference
        //ModifyByReference(ref value2);
        //Console.WriteLine($"After ModifyByReference: value2 = {value2}");
        #endregion

        #region 2. Reference Type: Pass by Value vs by Reference
        /*
         2.1. Passing Reference Type by Value (Default)
         A copy of the reference is passed to the method.
         The object on the heap can still be modified inside the method.
         But reassigning the parameter to a new object does not affect the original reference.
        */

        /*
         2.2 Passing Reference Type by Reference (ref)
          The reference itself is passed by reference (not a copy).
          You can modify the object and also reassign the reference to point to a completely new object, and that change affects the original variable. 
       */
        //int[] arr = { 1, 2, 3 };
        //Console.WriteLine($"Before: arr[0] = {arr[0]}");//1
        //ModifyArray(arr); // modifies because it's reference by default
        //Console.WriteLine($"After value-pass: arr[0] = {arr[0]}");//42
        //ChangeArray(ref arr); // changes array reference
        //Console.WriteLine($"After reference-pass: arr.Length = {arr.Length}");//10
        #endregion

        #region 3. Function with 4 Params - Sum and Subtract
        //Console.WriteLine(SumAndSubtract(10, 5, out int sum, out int diff));
        //Console.WriteLine($"Sum: {sum}, Difference: {diff}");
        #endregion

        #region 4. Sum of Digits Function
        // Console.Write("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //int result = SumOfDigits(num);
        //Console.WriteLine($"The sum of the digits of the number {num} is: {result}");
        #endregion

        #region 5. IsPrime Function
        //Console.Write("Enter number to check prime: ");
        //int primeCheck = int.Parse(Console.ReadLine());
        //Console.WriteLine(IsPrime(primeCheck) ? "Prime" : "Not Prime");
        #endregion


        #region 6. MinMaxArray with ref
        //int[] nums = { 7, 4, 2, 9, 1 };
        //MinMaxArray(nums, out int min, out int max);
        //Console.WriteLine($"Min = {min}, Max = {max}");
        #endregion

        #region 7. Iterative Factorial
        //Console.Write("Enter number for factorial: ");
        //int fact = int.Parse(Console.ReadLine());
        //Console.WriteLine($"Factorial of {fact} is {Factorial(fact)}");
        #endregion

        #region 8. Change Character in String
        //Console.WriteLine(ChangeChar("hello", 1, 'a')); // hallo
        #endregion
    }
}
