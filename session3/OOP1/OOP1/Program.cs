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
        }
    }
}
