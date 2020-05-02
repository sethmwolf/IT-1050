using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Exam
{
    public class Passenger
    
    {

        private string Name = "null";
        private double Weight = 0;

        public Passenger(string name, double weight)

        {

            Name = name;
            Weight = weight;

        }


        public string GetName()

        {

            return this.Name;

        }


        public double GetWeight()

        {

            return this.Weight;

        }








    }

    

}
