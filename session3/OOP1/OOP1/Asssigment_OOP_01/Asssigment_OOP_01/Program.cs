namespace Asssigment_OOP_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. WeekDays Enum - Print All Days
            //Console.WriteLine("Days of the Week:");
            //foreach (string day in Enum.GetNames(typeof(WeekDays)))
            //    Console.WriteLine(day);
            #endregion

            #region 2. Seasons Enum - Show Month Range
            //Console.Write("Enter a season name: ");
            //string? seasonInput = Console.ReadLine();
            //if (Enum.TryParse(seasonInput, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May"); 
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August"); 
            //            break;
            //        case Season.Autumn: 
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}
            #endregion

            #region 3. Permissions Enum - Bit Flags
            //Permission userPermissions = Permission.Read | Permission.Write;//Read+Write
            //Console.WriteLine($"Initial Permissions: {userPermissions}");

            //// Add permission
            //userPermissions |= Permission.Execute;// |= to accumulate permission without delete old permision
            //Console.WriteLine($"After Adding Execute: {userPermissions}");

            //// Remove permission
            //userPermissions &= ~Permission.Write;//i use =& to delete this permission bit
            //Console.WriteLine($"After Removing Write: {userPermissions}");

            //// Check permission
            //if (userPermissions.HasFlag(Permission.Delete))
            //    Console.WriteLine("Delete permission exists.");
            //else
            //    Console.WriteLine("Delete permission does NOT exist.");
            #endregion

            #region 4. Colors Enum - Primary Color Check
            //Console.Write("Enter a color name: ");
            //string? colorInput = Console.ReadLine();
            //if (Enum.TryParse<Colors>(colorInput, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{colorInput} is not a primary color.");
            //}
            #endregion
        }

    }
}
