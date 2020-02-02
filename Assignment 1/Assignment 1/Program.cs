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

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeight;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your middle initial?");
            middleInitial = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            Console.WriteLine("What is your height in feet (excluding inches)?");
            heightFeet = int.Parse(Console.ReadLine());

            Console.WriteLine("How many inches above " + heightFeet + " feet are you?");
            heightInches = double.Parse(Console.ReadLine());

            totalHeight = ((heightFeet * 12) + heightInches) * 2.54;

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a citizen?  Please type 'true' or 'false'");
            isCitizen = bool.Parse(Console.ReadLine());

            canVote = (age >= 18) && isCitizen;

            Console.WriteLine("Your full name is " + fullName);
            Console.WriteLine("Your height is " + totalHeight + " centimeters");
            Console.WriteLine("Can vote = " + canVote);

           
            // Below not part of assignment, just trying different responses


            int yearsToVote = 18 - age;
            string needCitizen = "You must be a citizen in order to vote. ";
            string tooYoung = "The voting age is 18. You must wait " + yearsToVote + " years to vote. ";

            if (isCitizen == false && age < 18)
                Console.WriteLine(needCitizen + tooYoung);

            if (isCitizen == true && age < 18)
                Console.WriteLine(tooYoung);

            if (isCitizen == false && age >= 18)
                Console.WriteLine(needCitizen);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
         
        }
    }
}
