using Common;
namespace Demo
{
    //What You Can Write Inside NameSpace?
    //1. Class
    //2. Struct
    //3. Enum
    //4. Interface

    //Acces Modifiers Allowed Inside Namespace?
    //1. Internal
    //2. Public

    //Default Access Modifer Inside Namespace ? Internal
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region Class Library
            //Product product = new Product()
            //{
            //    Id = 10,
            //    Name ="Iphone",
            //    Count = 10
            //};
            #endregion

            #region Access Modifier

            //TypeA typeA = new TypeA();
            //typeA.x = 1;//Invalid
            //typeA.y = 5;//Invalid 
            //typeA.z = 3;//Valid Because it is buplic

            #endregion

            #region Enum [Value Type]
            #region Examble01
            //Person person1 = new Person();
            //person1.Id = 10;
            //person1.Name = "Omar";
            ////person1.Gender = "Hamada";
            //person1.gender = Gender.Male; 
            #endregion

            #region Examble02
            //Grades Grd01=new Grades();
            ////Default of Int =>0
            //Grd01 = Grades.A;
            ////Console.WriteLine(Grd01);//A
            //if(Grd01==Grades.A||Grd01==Grades.B)
            //    Console.WriteLine("Bravo");
            //else
            //    Console.WriteLine(":(");
            //Grd01 = (Grades)4;
            //Console.WriteLine(Grd01);//D
            //Grd01 = (Grades)10;
            //Console.WriteLine(Grd01);//10

            //Gender Gen01 = new Gender();

            //Console.WriteLine(Gen01);
            //Gen01=Gender.Female;
            #endregion

            #region Examble03
            //Student std01 = new Student()
            //{
            //    Id = 1,
            //    Name = "Eman",
            //    Gender = Gender.Female,
            //    Branches = Branches.Dokki,
            //    Grades=Grades.B
            //};

            #endregion

            #region Examble04
            //Student std02 = new Student();
            //Console.WriteLine("Please Enter Data Of Student");
            //bool isParsed;
            //int stdId;
            //do
            //{
            //    Console.Write("ID:  ");
            //   isParsed= int.TryParse(Console.ReadLine(), out  stdId );

            //}
            //while (!isParsed);
            //std02.Id = stdId;
            //Console.Write("Name:");
            //std02.Name=Console.ReadLine();
            //object stdGender;
            //do
            //{
            //    Console.Write("Gender: ");
            //    isParsed = Enum.TryParse(typeof(Gender),Console.ReadLine() , out stdGender);
            //}
            //while (!isParsed|| stdGender is null);
            //std02.Gender=(Gender) stdGender;

            //Branches stdBranch;
            //do
            //{
            //    Console.Write("Branch: ");
            //    isParsed = Enum.TryParse<Branches>(Console.ReadLine(), out stdBranch); 
            //} while (!isParsed);
            //std02.Branches = stdBranch;


            //Grades stdGrades;
            //do
            //{
            //    Console.WriteLine("Grade: ");
            //    isParsed = Enum.TryParse(Console.ReadLine(), out stdGrades);
            //}
            //while (!isParsed);
            //std02.Grades = stdGrades;

            //Console.Clear();
            //Console.WriteLine($"Hello {std02.Name} Welcome To Route\n Your Branch is {std02.Branches}And Your Grade is {std02.Grades} ");
            //Console.ReadKey();
            #endregion

            #region Examble05
            //User user01 = new User();
            //user01.Id = 10;//4 byte
            //user01.Permision[0]=true;//Write
            //user01.Permision[1]=false;//Read
            //user01.Permision[2]=true;//Execute
            //user01.Permision[3]=false;//Delete
            ////4 Bytes 
            ////Data For each User 8 Bytes

            //User user02 = new User();
            //user02.Id = 20;
            //user02.Permision[0] = true;//Write
            //user02.Permision[1] = true;//Read
            //user02.Permision[2] = false;//Execute
            //user02.Permision[3] = false;//Delete
            //Data For each User 8 Bytes

            User user01 = new User();
            user01.Id = 10;// 4 Bytes
            user01.Permission = Permissions.Write; //1 Byte
            user01.Permission = (Permissions)4;
            Console.WriteLine(user01.Permission);
            User user02 = new User();
            user02.Id = 20;
            user01.Permission = (Permissions)10;//Flags 00001010 Execute+Write (Decimal.System==>Binary.System)

            User user03 = new User();
            user03.Id =30;
            user03.Permission = (Permissions)3;
            Console.WriteLine(user03.Permission);//Delete,Execute,Read

            user03.Permission = Permissions.Delete;
            Console.WriteLine(user03.Permission);//Delete

            user03.Permission = user03.Permission & Permissions.Delete;

            //Add Permission [Flag]To User
            user03.Permission = user03.Permission ^ Permissions.Read;//هتحول الاتنين ل Binary وتشتغل عليهم
            Console.WriteLine(user03.Permission);
            //Deny|Remove Permission Read [Flag] from user
            user03.Permission^= Permissions.Read;
            Console.WriteLine(user03.Permission);

            //Check If User Has Execute Permisson Or Not
            if ((user03.Permission & Permissions.Execute) == Permissions.Execute)
                Console.WriteLine("User Has Execute Permission");
            else Console.WriteLine("User Has not Execute Permission");
            //Check If User Has Execute Permisson Or Not
            bool hasExecute =user03.Permission.HasFlag(Permissions.Execute);
            if (hasExecute)
                Console.WriteLine("User Has Execute Permission");
            else
                user03.Permission ^= Permissions.Execute;
            //Check If User Has Delete Permisson Or Not
            //if existed => Do Nothing
            //If not Existed => Add it
            //Do | Or Operator

            user03.Permission = user03.Permission | Permissions.Delete;
            Console.WriteLine(user03.Permission);

            user03.Permission=user03.Permission | Permissions.Write;
            Console.WriteLine(user03.Permission);



            #endregion
            #endregion
        }
    }
}
