using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;

            while (Count < 3)

            {

                System.Console.WriteLine("How Many People In Your Group? ");
                Count = int.Parse(System.Console.ReadLine());

                if (Count < 3)

                {
                    
                    System.Console.WriteLine("Sorry, your group must consist of at least 3 people.  Please try again." +Environment.NewLine);

                }


            }
            
            



            Person[] Group = new Person[Count];

            for (int i = 0; i<Count; i++)

            {
                System.Console.WriteLine("What is the First Name of Person #" + (i + 1) + "? ");
                string FirstNameofArrayPerson = System.Console.ReadLine();

                System.Console.WriteLine("What is the Last Name of Person #" + (i + 1) + "? ");
                string LastNameofArrayPerson = System.Console.ReadLine();

                Group[i] = new Person(FirstNameofArrayPerson, LastNameofArrayPerson);

            }


            for (int i = 0; i < Count; i++)

            {

                System.Console.WriteLine("The name of Person #" + (i + 1) + " is ");
                Group[i].PrintFullName();

            }

            System.Console.ReadKey();


        }
    }
}
