using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Matinee = false;
            int CycleCount = 0;
            double Discount = 0;
            bool FreePopcorn = false;
            double FreeCandy = 0;
                              
            //Check if going to a matinee
            

            System.Console.Write("Are you going to a matinee (y/n)? ");
            string MatineeResponse = System.Console.ReadLine();
            if (MatineeResponse.ToUpper().Contains("Y"))
            {
                Matinee = true;
            }
            
            //If the people are going to a matinee, set the static class matinee variable to "true"
            
            Person.Matinee = Matinee;

            //Find out how many people are going to the movie and set variables to create an array and assign values to instances
            
            System.Console.Write(Environment.NewLine + "How many people are in your group? ");
            int Count = int.Parse(System.Console.ReadLine());
            CycleCount = Count;
            int X = 0;
            int PlaceInLine = 1;

            //Create an array of people that is the size of # of people going
            
            Person[] Group = new Person[Count];

            //Obtain the name and age of each person in the group
            
            while (CycleCount > 0)

            {

                Group[X] = new Person();

                System.Console.WriteLine(Environment.NewLine + "Let me ask some questions about guest # " + PlaceInLine);
                System.Console.Write("What is this person's name? ");
                Group[X].Name = System.Console.ReadLine();

                System.Console.Write("How old is " + Group[X].Name + "? ");
                Group[X].Age = int.Parse(System.Console.ReadLine());

                //make the person a child if under 18, or a senior if over 65  
                
                if (Group[X].Age < 18)
                    
                    {

                    Group[X].isChild = true;

                    }

                   else if (Group[X].Age >= 65)

                    {

                    Group[X].isSenior = true;

                    }

                //Obtain the person's ticket cost 

                Group[X].PersonsTicketCost();
               
               //Obtain the person's food order 
                
                Group[X].GetFoodOrder();

               //Display the total cost of the person's ticket and food before discounts
                
                System.Console.WriteLine("The total price for  " + Group[X].Name + " is $" + Group[X].TotalIndividualCost + " before discounts.");

               
                X++;
                PlaceInLine++;
                CycleCount--;

                
            }

            //Calculate and display the total cost of the group before discounts

            Person.GetTotalGroupCost();

           
            //Generate a $2 discount for each combination of 1 large soda and 1 popcorn
            
           if (Person.GroupPopcorn >= 1 && Person.GroupLargeSoda >= 1)

            {

                if (Person.GroupPopcorn >= Person.GroupLargeSoda)

                {

                    Discount += Person.GroupLargeSoda * 2;

                }

                else if (Person.GroupPopcorn < Person.GroupLargeSoda)

                {

                    Discount += Person.GroupPopcorn * 2;

                }

            }

           //Identify whether the group will get free popcorn by buying 3 or more tickets

            if ((Person.GroupAdultEveningTickets + Person.GroupChildEveningTickets + Person.GroupSeniorEveningTickets) >= 3 )

            {
               FreePopcorn = true;
            }

            //Identify the nubmer of free candies the group will get for each 3 candies purchased
            
            if (Person.GroupCandy >= 3)

            {
                              
                FreeCandy = Person.GroupCandy / 3;

            }

            //Display all discounts received

            if (Discount >= 0.01)

            {

                System.Console.Write(Environment.NewLine + "You have earned a discount of $" + Discount);
                System.Console.Write(Environment.NewLine + "Your group's new total cost is $" + (Person.GroupTotalCost - Discount));

            }

            if (FreePopcorn == true)

            {

                System.Console.WriteLine(Environment.NewLine + "Also, you get a bag of free popocorn");

            }

            if (FreeCandy >= 1)

            {
                if (FreeCandy == 1)

                {

                    System.Console.WriteLine(Environment.NewLine + "Also, you get " + FreeCandy + " bag of free candy.");

                }

                else

                {

                    System.Console.WriteLine(Environment.NewLine + "Also, you get " + FreeCandy + " bags of free candy.");

                }

            }

            System.Console.WriteLine("Press any key to continue . . .");
            System.Console.ReadKey();

        }

            




        }
    }

