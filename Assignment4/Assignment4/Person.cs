using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Person
    {
        public static bool Matinee;
        public static int GroupSmallSoda;
        public static int GroupLargeSoda;
        public static int GroupHotDog;
        public static int GroupPopcorn;
        public static int GroupCandy;
        public static int GroupAdultEveningTickets;
        public static int GroupAdultMatineeTickets;
        public static int GroupChildEveningTickets;
        public static int GroupChildMatineeTickets;
        public static int GroupSeniorEveningTickets;
        public static int GroupSeniorMatineeTickets;
        public static double GroupTotalCost;

        public string Name;
        public int Age;
        public bool isChild;
        public bool isSenior;
        public int NumberSmallSoda;
        public int NumberLargeSoda;
        public int NumberHotDog;
        public int NumberPopcorn;
        public int NumberCandy;
        public double TotalIndividualCost;

        public void PersonsTicketCost()

        {

            if (this.isChild == true && Matinee == true)

            {
                this.TotalIndividualCost += Prices.MatineeChildTicket;
                GroupChildMatineeTickets++;
            }

            if (this.isChild == true && Matinee == false)

            {
                this.TotalIndividualCost += Prices.EveningChildTicket;
                GroupChildEveningTickets++;
            }

            if (this.isSenior == true && Matinee == true)

            {
                this.TotalIndividualCost += Prices.MatineeSeniorTicket;
                GroupSeniorMatineeTickets++;
            }

            if (this.isSenior == true && Matinee == false)

            {
                this.TotalIndividualCost += Prices.EveningSeniorTicket;
                GroupSeniorEveningTickets++;
            }

            if (Matinee == true && isChild == false && isSenior == false)

            {
                this.TotalIndividualCost += Prices.MatineeAdultTicket;
                GroupAdultMatineeTickets++;
            }

            if (Matinee == false && isChild == false && isSenior == false)

            {
                this.TotalIndividualCost += Prices.EveningAdultTicket;
                GroupAdultEveningTickets++;
            }

        }

        public void GetFoodOrder()

        {

            System.Console.Write("How many small sodas does " + this.Name + " want? ");
            this.NumberSmallSoda = int.Parse(System.Console.ReadLine());
            this.TotalIndividualCost += this.NumberSmallSoda * Prices.SmallSoda;
            GroupSmallSoda += this.NumberSmallSoda;

            System.Console.Write("How many large sodas does " + this.Name + " want? ");
            this.NumberLargeSoda = int.Parse(System.Console.ReadLine());
            this.TotalIndividualCost += this.NumberLargeSoda * Prices.LargeSoda;
            GroupLargeSoda += this.NumberLargeSoda;

            System.Console.Write("How many hot dogs does " + this.Name + " want? ");
            this.NumberHotDog = int.Parse(System.Console.ReadLine());
            this.TotalIndividualCost += this.NumberHotDog * Prices.HotDog;
            GroupHotDog += this.NumberHotDog;

            System.Console.Write("How many popcorns does " + this.Name + " want? ");
            this.NumberPopcorn = int.Parse(System.Console.ReadLine());
            this.TotalIndividualCost += this.NumberPopcorn * Prices.Popcorn;
            GroupPopcorn += this.NumberPopcorn;

            System.Console.Write("How many candys does " + this.Name + " want? ");
            this.NumberCandy = int.Parse(System.Console.ReadLine());
            this.TotalIndividualCost += this.NumberCandy * Prices.Candy;
            GroupCandy += this.NumberCandy;

        }

        public static void GetTotalGroupCost()

        {

            GroupTotalCost += GroupChildMatineeTickets * Prices.MatineeChildTicket;
            GroupTotalCost += GroupChildEveningTickets * Prices.EveningChildTicket;
            GroupTotalCost += GroupSeniorMatineeTickets * Prices.MatineeSeniorTicket;
            GroupTotalCost += GroupSeniorEveningTickets * Prices.EveningSeniorTicket;
            GroupTotalCost += GroupAdultMatineeTickets * Prices.MatineeAdultTicket;
            GroupTotalCost += GroupAdultEveningTickets * Prices.EveningAdultTicket;
            GroupTotalCost += GroupSmallSoda * Prices.SmallSoda;
            GroupTotalCost += GroupLargeSoda * Prices.LargeSoda;
            GroupTotalCost += GroupHotDog * Prices.HotDog;
            GroupTotalCost += GroupPopcorn * Prices.Popcorn;
            GroupTotalCost += GroupCandy * Prices.Candy;

            System.Console.WriteLine(Environment.NewLine + "The total cost of your group before discounts is $" + GroupTotalCost);
        }
        
    }
}

    
    

