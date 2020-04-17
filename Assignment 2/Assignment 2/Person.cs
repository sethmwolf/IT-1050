using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class Person
    {
        public static double SumOfAllAges = 0;
        public static int Count = 0;

        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAge()
        {
            System.Console.WriteLine(this.GetFullName() + " is " + this.Age + " years old.");
          
        }

        public void GetInformation()
        {
            System.Console.WriteLine("What is your first name?:");
            this.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name?:");
            this.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your age?:");
            this.Age = int.Parse(System.Console.ReadLine());

            Count++;

            SumOfAllAges += this.Age;


        }

       
        public void CreatePersonifMarried()
        {
            System.Console.WriteLine("Are you married?:");

            string MarriedResponse = System.Console.ReadLine();

            if (MarriedResponse.Equals("Yes") || MarriedResponse.Equals("yes") || MarriedResponse.Equals("Y") || MarriedResponse.Equals("y"))
            {
                this.Spouse = new Person();

                this.Spouse.GetInformation();

                this.Spouse.Spouse = this;

             }

        }

      
    }

    
}
