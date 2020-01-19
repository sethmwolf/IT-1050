using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");

            string firstName = Console.ReadLine();

            Console.WriteLine("What is your middle initial?");

            string middleInitial = Console.ReadLine();

            Console.WriteLine("What is your last name?");

            string lastName = Console.ReadLine();

            string fullName = firstName + " " + middleInitial + ". " + lastName;

            Console.WriteLine("What is your age?");

            int age = int.Parse(Console.ReadLine());

            int yearsToVote = 18 - age;

            Console.WriteLine("How tall are you in feet (exclude inches)?");

            int feet = int.Parse(Console.ReadLine());

            Console.WriteLine("How many inches are you beyond " + feet + " feet?");

            double inches = double.Parse(Console.ReadLine());

            double centimeters = ((feet * 12) + inches) * 2.54;

            Console.WriteLine("Are you a U.S. citizen?  Enter true or false:");

            bool isCitizen = bool.Parse(Console.ReadLine());

            bool canVote = (age >= 18) && isCitizen;

            bool oldEnoughToVote = (age >= 18);

            Console.WriteLine("Your full name is " + fullName);

            Console.WriteLine("Your age is " + age + " years old");

            Console.WriteLine("You are " + feet + " feet, " + inches + " inches tall");

            Console.WriteLine("You are " + centimeters + " centimeters tall");

            if (canVote == true) Console.WriteLine("You are eligible to vote");

            if ((isCitizen == false) && (oldEnoughToVote == false)) Console.WriteLine("You are ineligible to vote.  You must obtain U.S. citizenship in order to vote, and you must wait " + yearsToVote + " years to reach the minimum voting age of 18.");

            if ((isCitizen == false) && (oldEnoughToVote == true)) Console.WriteLine("You are ineligible to vote.  You must obtain U.S. citizenship in order to vote.");

            if ((oldEnoughToVote == false) && (isCitizen == true)) Console.WriteLine("You are ineligible to vote.  You must wait " + yearsToVote + " years to reach the minimum voting age of 18.");

       
            string pressKey = Console.ReadLine();

        }
    }
}
