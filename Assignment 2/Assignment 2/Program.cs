using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Person p1 = new Person();
            p1.GetInformation();
            p1.CreatePersonifMarried();

            Person p2 = new Person();
            p2.GetInformation();
            p2.CreatePersonifMarried();

            p1.PrintNameAge();
            p1.Spouse.PrintNameAge();
            p2.PrintNameAge();
            p2.Spouse.PrintNameAge();

            double AverageAge = Person.SumOfAllAges / Person.Count;
            Console.WriteLine("Average Age is " + AverageAge + " years old");

            Console.WriteLine("Press any key . . .");
            Console.ReadKey();

        }
    }
}
