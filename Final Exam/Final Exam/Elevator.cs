using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Exam
{
    public class Elevator
    {

        private double MaxWeight = 0;
        private Passenger[] Occupants;
        private double CurrentWeight = 0;
        
        

        public Elevator(int maxOccupants, double maxWeight)

        {

            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;

        }
            

        public void AddOccupant(Passenger passenger, int index)

        {

            Occupants[index] = passenger;
          
        }


        public double GetCurrentWeight()

        {

           foreach(Passenger Occupant in Occupants)

            {
               
                CurrentWeight += Occupant.GetWeight();

            }

            return CurrentWeight;

        }

        public bool IsOverMaxCapacity()
        {



            if (this.CurrentWeight > this.MaxWeight)

            {

                return true;

            }

            return false;
            
        }


    }
}
