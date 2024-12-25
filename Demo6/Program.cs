using System.Data;
using Common;
namespace Demo6
{
    enum Gender : int
    {
        Male = 1, Female = 2
    }
    enum Days
    {
        Saturday = 10,
        Sunday,
        Mondady,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,



    }
    enum Grades
    {
        A, B, C, D, E, F
    }
    enum Branches : byte
    {
        Nasrcity, Maadi = 251, Alex, Dokki, Enhaas, SmartVillage
    }
    enum Permissons
    {
        Delete, Execute, Read, Write
    }

    class Employee
    {
        public string Name;
        public int Age;
        public decimal Salary;
        public Gender Gender;
        public Permissons Permissons;

    }

    internal class Program
    {
        public static void DosSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;
                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
        public static void DoSomeProtectiveCode()
        {
            int X, Y, Z;
            bool Flag;

            do
            {
                Console.WriteLine("Enter First Number");
                Flag = int.TryParse(Console.ReadLine(), out X);
            } while (!Flag);

            do
            {
                Console.WriteLine("Enter Second Number");
                Flag = int.TryParse(Console.ReadLine(), out Y);
            } while (!Flag || Y == 0);

            Z = X / Y;

            int[] Numbers = null;

            if (Numbers?.Length > 10)
            {
                Numbers[10] = 100;
            }
        }

        static void Main(string[] args)
        {
            #region Exception Handling
            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finaly");
            //}
            //Console.WriteLine("After try Catch");
            #endregion
            #region Access Modifer
            //TypeA typeA = new TypeA();
            ////TypeB
            ////typeA.X = 10;
            ////typeA.Y = 10;
            //typeA.Z = 10;

            #endregion
            #region Enums
            #region Ex01
            //Days Day = Days.Friday;
            //Grades grade = Grades.A;
            //if (grade == Grades.A) 
            //{
            //    Console.WriteLine(":)");

            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}    
            #endregion
            #region Exo02
            //Grades grade = (Grades)2;
            //Console.WriteLine(grade);
            //Grades grade = (Grades)10;//
            //Console.WriteLine(grade);
            #endregion
            #region Ex03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
            //Grades grade = (Grades)Result;
            //Console.WriteLine(Result);
            #endregion
            #region Ex04
            //String gender = "Male";
            //Enum.TryParse(typeof(Gender), gender, out object Result);
            //Console.WriteLine(Result);
            //Enum.TryParse<Gender>(gender, true,out Gender Result);
            //Console.WriteLine(Result);
            #endregion
            #endregion
            #region Permissons
            //Employee employee = new Employee();
            //    employee.Name = "Ali";
            //    employee.Age = 20;
            //    employee.Permissons = (Permissons)7;
            //    Console.WriteLine(employee.Permissons);
            //    //XOR
            //    employee.Permissons = employee.Permissons ^ Permissons.Read;
            //    Console.WriteLine(employee.Permissons);

            //    employee.Permissons = employee.Permissons ^ Permissons.Read;
            //    Console.WriteLine(employee.Permissons);

            //    //&
            //    if ((employee.Permissons & Permissons.Read) == Permissons.Read)
            //    {
            //        Console.WriteLine("Read is Exist");
            //    }
            //    else {
            //        employee.Permissons = employee.Permissons ^ Permissons.Read;
            //    }
            //    //or
            //    employee.Permissons = employee.Permissons | Permissons.Read;
            //    Console.WriteLine(employee.Permissons); 
            //}
            #endregion
            #region Part 06 Struct
            Point P01;
            //Console.WriteLine(P01.X);
            //P01.X = 10;
            //P01.Y = 20;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);
            P01 = new Point(2);
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);
            Console.WriteLine(P01);
            Console.WriteLine(P01);
            //int X = 10;
            //Console.WriteLine(X);
            //Console.WriteLine(X.ToString());
            Point P02 = new();
            #endregion
            #region Enum Roles
            //enum Roles
            //{
            //    Admin =10, Viewer = 20, Editor
            //} 
            #endregion



        }
    }
}


