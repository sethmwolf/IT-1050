using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");

            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane", John, 0);

            Student Joe = new Student("Joe", John, 0);

            Student Melissa = new Student("Melissa", Mike, 0);

            Student Matt = new Student("Matt", Mike, 0);

            John.SetStudentGrade(Jane, 95);

            John.SetStudentGrade(Joe, 85);

            Mike.SetStudentGrade(Melissa, 90);

            Mike.SetStudentGrade(Matt, 92);

            Console.WriteLine(Jane.PrintStudentInfo());

            Console.WriteLine(Joe.PrintStudentInfo());

            Console.WriteLine(Melissa.PrintStudentInfo());

            Console.WriteLine(Matt.PrintStudentInfo());

            Console.WriteLine("Press any key . . ");

            Console.ReadKey();

            


        }
    }
}
