#region 1. Enter and Print a Number
Console.Write("Enter a number: ");
string input = Console.ReadLine()??"0";
Console.WriteLine($"You entered: {input}");
#endregion

#region 2. Convert Non-Numeric String to Integer
string str = "123abc";
try
{
    int parsedResult = int.Parse(str);
    Console.WriteLine($"Parsed number: {parsedResult}");
}
catch (FormatException)
{
    Console.WriteLine("Cannot convert string to integer: FormatException will occur.");
}
#endregion

#region 3. Floating-Point Arithmetic
float a = 10.5f, b = 3.2f;
float sum = a + b;
Console.WriteLine($"Sum: {sum}");
#endregion

#region 4. Extract Substring
string text = "Hello World!";
string substring = text.Substring(6, 5);
Console.WriteLine($"Substring: {substring}");
#endregion

#region 5. Value Type Assignment
int x = 5;
int y = x;
x++;
Console.WriteLine($"x: {x}, y: {y}");
#endregion

#region 6. Reference Type Assignment
int[] arr1 = { 1, 2 };
int[] arr2 = arr1;
arr1[0] = 99;
Console.WriteLine($"arr2[0]: {arr2[0]}");
#endregion

#region 7. Concatenate Strings
string first = "Hello", second = "World";
string combined = first + " " + second;
Console.WriteLine(combined);
#endregion

#region 8. Simple Interest Calculation
Console.Write("Enter Principal: ");
double principal = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Rate: ");
double rate = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Time: ");
double time = Convert.ToDouble(Console.ReadLine());
double interest = (principal * rate * time) / 100;
Console.WriteLine($"Simple Interest: {interest}");
#endregion

#region 9. BMI Calculation
Console.Write("Enter Weight (kg): ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Height (m): ");
double height = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
Console.WriteLine($"BMI: {bmi}");
#endregion

#region 10. Ternary Temperature Check
Console.Write("Enter temperature: ");
int temp = Convert.ToInt32(Console.ReadLine());
string result = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
Console.WriteLine(result);
#endregion

#region 11. Date Format Display
Console.Write("Enter day: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter month: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter year: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Today's date: {day} , {month} , {year}");
Console.WriteLine($"Today's date: {day} / {month} / {year}");
Console.WriteLine($"Today's date: {day} – {month} – {year}");
#endregion

#region 12. Divisible by 3 and 4
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num % 3 == 0 && num % 4 == 0 ? "Yes" : "No");
#endregion

#region 13. Positive or Negative
Console.Write("Enter a number: ");
int signCheck = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(signCheck < 0 ? "negative" : "positive");
#endregion

#region 14. Max and Min of 3 Integers
Console.Write("Enter 3 numbers separated by space: ");
string? inputValues = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(inputValues))
{
    string[] values = inputValues.Split();
    if (values.Length >= 3)
    {
        int n1 = int.Parse(values[0]);
        int n2 = int.Parse(values[1]);
        int n3 = int.Parse(values[2]);
        int max = Math.Max(n1, Math.Max(n2, n3));
        int min = Math.Min(n1, Math.Min(n2, n3));
        Console.WriteLine($"Max element = {max}\nMin element = {min}");
    }
    else
    {
        Console.WriteLine("Please enter exactly 3 numbers.");
    }
}
else
{
    Console.WriteLine("Invalid input.");
}
#endregion

#region 15. Even or Odd
Console.Write("Enter a number: ");
int checkEven = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(checkEven % 2 == 0 ? "Even" : "Odd");
#endregion

#region 16. Vowel or Consonant
Console.Write("Enter a character: ");
char ch = Char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();
Console.WriteLine("aeiou".Contains(ch) ? "Vowel" : "Consonant");
#endregion

#region 17. Days in Month
Console.Write("Enter month number: ");
int m = Convert.ToInt32(Console.ReadLine());
int days = DateTime.DaysInMonth(2024, m);
Console.WriteLine($"Days in Month: {days}");
            #endregion
        