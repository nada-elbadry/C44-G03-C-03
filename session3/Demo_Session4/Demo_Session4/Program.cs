
#region Evolution of switch in c#
#region C# 7.0 [Pattern matching - Case Guards(when)]
using Demo_Session4;
using System.Net.WebSockets;
using System.Text;
using System.Xml.Linq;
//object number = 5.6;//Boxing
#region Examble 01 [Pattern matching one types]
/*
//No Jumb Table Will Be Created
switch(number)
{
    case int value://Unboxing
        Console.WriteLine("Integer");
        break;
        case decimal value:
        Console.WriteLine("Decimal");
        break;
        case double value:
        Console.WriteLine("Double");
        break;
        default:
        Console.WriteLine("No Matching");
        break;
}
*/
#endregion

#region Examble 02 [Case Guards(when)]
/*
switch (number)
{
    case int value when value<10:
        Console.WriteLine("Integer is less than 10");
        break;

    case int value when value> 10:
        Console.WriteLine("Integer is bigger than 10");
        break;

    case decimal value:
        Console.WriteLine("Decimal");
        break;
    case double value when value>5.5 &&value < 10.10:
        Console.WriteLine("Double between 5.5 and 10.10");
        break;
    default:
        Console.WriteLine("No Matching");
        break;
}
*/
#endregion

#region Examble 03 [User_Defined Data Type]
/*
object input = 50;//Boxing
input = new Person() { Id = 10, Name = "Omar", Age = 25 };
switch(input)
{
    case int value when value>10:
        Console.WriteLine("Int greater than10");
        break;
    case string value:
        Console.WriteLine("String");
        break;
    case Person value when value.Id==10 && value.Name=="Omar"://short Cricut
        Console.WriteLine("Person");
        break;
    default:
        Console.WriteLine("No Matching");
        break;
}
*/
#endregion

#endregion
#region C#8.0[Pattern Mathcing without alias name - Switch Expresssion- Property Pattern]
#region Example 01 - Pattern matching without alias name
/*
object number = 5.6;

switch(number)
{
    case int:
        Console.WriteLine("Intger");
        break;
        case decimal:
        Console.WriteLine("Decimal");
        break;
        case double when (double)number>5.5 && (double)number < 10.10:
        Console.WriteLine("Double number Between 5.5 and 10.10");
        break;
}
*/
#endregion
#region Switch Case Before Switch Expression
/*
string option = Console.ReadLine()??"0";
string message;
switch (option)
{
    case "1":
        //Console.WriteLine("Option 01");
        message = "Option 01";
            break;
    case "2":
        message = "Option 02";
             break;
    case "3":
        message = "Option3";
        break;
    default:
        message = "Invalid Option" ;
        break;
}
Console.WriteLine(message);
*/
#endregion
#region Examble 02 Swith Expression [Constant Pattern - Discard Pattern]
/*
Console.Write("Enter Your Number:");
string option = Console.ReadLine()??"0";
string message;

message = option switch
{
    "1"=>"Option 01",
    "2"=>"Option 02",
    "3"=>"Option 03",
     _ =>"Invalid Option"
};
Console.WriteLine(message);
*/
#endregion
#region Examble 03 [Property Pattern]
/*
Person person = new Person() { Id=10, Name="Omar",Age=25};
string message = person switch
{
    { Name: "Ahmed", Age: 10 } => "Hello Ahmed",
    { Name:"Omar"}=>"Hello Omar",
    { Id:50}=>"Hello Person With Id=50",
    _=>"Sorry we dont know you "
};
Console.WriteLine(message);
*/
#endregion
#region Examble 04 [Nullable Type - Relational Patterns(Partially)]
/*
//number= null  --> Nullable Type
//number=  10   --> Positive Number
//number=  -10  --> Negative Number
//number=  0    --> Zero
int? number=10;
string Result = number switch
{
    null=>"Nullable Type",
    int x when x> 0 =>"Positive number",
    int x when x < 0 => "Negative number",
   0=>"Zero"

};
Console.WriteLine(Result);
*/
#endregion
#endregion
#region C# 9.0 [Switch Expresssion With Relational Patterns - Logical Patterns - Enhanced Property Matching]
#region Examble 01 [Relational Patterns]
/*
// Number Less Than 10
//Number Between 10 And 20
//Number Greater Than 20

int number = 20;
string Result = number switch
{ 
    <10 => "Less Than 10",
    >=10 and <= 20 => "Number is between 10 and 20",
    >20 =>"Number Is Greater Than 20"
};
Console.WriteLine(Result);
*/
#endregion
#region Examble 02 [Logical Patterns (and,or)]
/*
///Number Between 1 and 9
///Number Between 10 and 20
///Number is Zero
///Number Outside Th e Range

int number = 10;
string Result = number switch
{
    >0 and <10 => "Number  is Between 1 and 9",
    >=10 and <=20 => "Number is Between 10 and 20",
    0 => "Number is Zero",
   // _=>"Number Outside The Range"
    >20 or <0 => "Number Outside The Range"
};
Console.WriteLine(Result);
*/
#endregion
#region Examble 03 [Enhanced Property Matching]
/*
/// Person is samy and his Age is Greater Than 10
/// Person is omar and his Age is between 20 and 24
/// Person is Age between 50 and 60
/// Any one Else [Sorry But We Dont Know You]

Person person = new Person() { Id =10 , Age=25 ,Name="Omar"};
string Result = person switch
{
    { Name:"Samy",Age: >10}=>"Hello Samy",
    { Name:"Omar",Age: >=20 and  <= 24}=>"Hello Omar",
    { Age: >50 or < 60}=>"Hello Old Man",
    _=>"Sorry We dont know you"
};
Console.WriteLine(Result);
*/
#endregion
#endregion
#endregion

#region Loooping Iteration Statements
/*
//Manual Code Repetaion
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);
Console.WriteLine(6);
Console.WriteLine(7);
Console.WriteLine(8);
Console.WriteLine(9);
Console.WriteLine(10);
//10Steps
Console.WriteLine("===============================");
for (int i = 0; i <=10 ; i++)
{
    Console.WriteLine(i);
}
*/

#region for - foreach

////                0  1  2  3   4 
//int[] numbers = { 1, 2, 3, 4, 5 };
/////Console.WriteLine(numbers[0]);//1
/////Console.WriteLine(numbers[1]);//2
/////Console.WriteLine(numbers[2]);//3
/////Console.WriteLine(numbers[3]);//4
/////Console.WriteLine(numbers[4]);//5
//for (int i = 0; i <numbers.Length /*5*/; i++)//faster than foreach
//{
//    if(i==2)
//        //continue;//Skip current Iteration
//    break;//Exit From loop
//    //numbers[i] += 10;
//    Console.WriteLine(numbers[i]);
//}
//foreach (int item in numbers)
//{
//    //item += 10;//invalid
//    Console.WriteLine(item);
//}//get elmenator function هتاخد اول رقم من الnumbersوتحطه في الitem
// //call move next function check true or false then if true call get current property else loop will be end

#endregion

#region while - do while
#region do while
/*
///Let User Enter an Even Number
///if Value Is an Odd number ->Enter value again
///if it is not a number -> enter value again
///if value is an even number -> print number
bool isParsed;
int number;
do
{
    Console.WriteLine("Please Enter Even Number: ");
     isParsed = int.TryParse(Console.ReadLine(), out  number);
    
} 
while (!isParsed||number%2==1);
//isParsed =True -> !isParsed =  False || number %2==1
// isParsed= False ->!isParsed = True
Console.WriteLine($"{number}Is An Even Number");
*/
#region while
/*
/// Take a number from user  and print
/// a sequence of number from enterd number to 10
// 5 => 5,6,7,8,9,10
//2=>2,3,4,5,6,7,8,9,10
Console.WriteLine("Enter a Number");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (isParsed)
{
    while (number <= 10)
    {
        Console.WriteLine(number);
        number++;
    }
}
*/
#endregion
#endregion
#endregion
//www. mediumm -> test performance 
#endregion

#region String
//string name = "Nada";//unreachable object
//name = "Nada Elbadry";


#region Examble 01  
//string name;
//Declare for reference from type string 'name'
//reference 'name' is refering to default value of reference type[Null]
// CLR will allocate 4 bytes at stack from reference 'name'
//0 Bytes allocated at heap
//name = new string("Route");
//Allocate Required bytes at heap [10 bytes]
//initalize allocated bytes
//call user defined constructor
//assign reference 'name' with adress allocated object
//Console.WriteLine($"Name:{name}");//Route
//Console.WriteLine($"HashCode Name:{name.GetHashCode()}");//505658453

//string name02 = "Route";//string literal = sentaqs sugar
//CLR Will Checks If The String 'Route' is Already Exists
//If is not exists -> Add New String  in pool
//if It is Exists -> Reuse Same Memory Location
//Console.WriteLine($"Name:{name02}");//Route
//Console.WriteLine($"HashCode Name:{name02.GetHashCode()}");//505658453

//char x=default;//\0
//Console.WriteLine((int)x);//space   //0
#endregion

#region Examble 02
string name01 = "Amr";
string name02 = "May";
Console.WriteLine($"Name 01:{name01}");
Console.WriteLine($"HashCode Name:{name01.GetHashCode()}");
Console.WriteLine($"Name 01:{name02}");
Console.WriteLine($"HashCode Name:{name02.GetHashCode()}");
name02 = name01;
Console.WriteLine("After Assign name02=name01");
Console.WriteLine($"Name 01:{name01}");
Console.WriteLine($"HashCode Name:{name01.GetHashCode()}");
Console.WriteLine($"Name 01:{name02}");
Console.WriteLine($"HashCode Name:{name02.GetHashCode()}");
name01 = "omar";
Console.WriteLine($"Name 01:{name01}");
Console.WriteLine($"HashCode Name:{name01.GetHashCode()}");
Console.WriteLine($"Name 01:{name02}");
Console.WriteLine($"HashCode Name:{name02.GetHashCode()}");
Console.WriteLine("After Changing name0 Value");
Console.WriteLine($"Name 01:{name01}");
Console.WriteLine($"HashCode Name:{name01.GetHashCode()}");
Console.WriteLine($"Name 01:{name02}");
Console.WriteLine($"HashCode Name:{name02.GetHashCode()}");

#endregion

#region Examble03
/*
string message = "Hello";
Console.WriteLine(message);
Console.WriteLine(message.GetHashCode());
message += "Route";
Console.WriteLine("After Changing in message");
Console.WriteLine(message);
Console.WriteLine(message.GetHashCode());
*/
#endregion
#region string Methods
//string message = "  Hello Route  ";
//Console.WriteLine(message.Length);
//Console.WriteLine(message.ToUpper());
//Console.WriteLine(message.ToLower());
//Console.WriteLine(message.Trim());
//Console.WriteLine(message.TrimStart());
//Console.WriteLine(message.TrimEnd());
//Console.WriteLine(message.Substring(0,5));
//Console.WriteLine(message.Replace('e', 'm'));
//Console.WriteLine(message.Contains('o')) ;
#endregion
#region Stringbuilder
//it is  a mutanle string
//Internaly is represented as a linked list of characters
//StringBuilder message;
//Declare Reference From Type stringbuilder 'message'
//reference 'Message' Is Referring To Null
//CLR Will Allocate 4 bytes At stack For Reference 'message'
// 0 bytes allocated at heap
//message = new StringBuilder("Hello");

//Console.WriteLine($"message = {message}");
//Console.WriteLine($"Hashcode of message = {message.GetHashCode()}");
//message.Clear();
//message.Append("Route");
//Console.WriteLine("After Changing");
//Console.WriteLine($"message = {message}");
//Console.WriteLine($"Hashcode of message = {message.GetHashCode()}");

#endregion
#region Stringbuilder Methods
//StringBuilder message = new StringBuilder("Hello");
//message.Append("Route");
//message.AppendLine("Welcome");
//message.Append("New Student");
//message.Replace("New Student", "Amr");
//message.Remove(0, 5);
//message.Insert(0, "Hi");
//message.AppendLine("Amr");
//int age = 25;
//message.AppendFormat("Your Age is {0}", age);
//message.AppendJoin('_', "Mohamed", "Nada", "Nora");
//Console.WriteLine(message);
#endregion
#endregion