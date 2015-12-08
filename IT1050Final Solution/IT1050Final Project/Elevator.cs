﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Final_Project
{
    public class Elevator
    {
        private double MaxWeight;
        private int MaxOccupants;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            MaxOccupants = maxOccupants;
            MaxWeight = maxWeight;
            Occupants = new Passenger[maxOccupants];
        }
        
        public void AddOccupant(int index, Passenger passenger)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            foreach (Passenger passenger in Occupants)
            {
                totalWeight += passenger.GetWeight();
            }

            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() <= MaxWeight)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        //Step 2 – Create a class called “Elevator”:
        // Two private member variables:
        //o MaxWeight, which is a double.
        //o Occupants, which is an array of Passengers.
        // One public constructor:
        //o Takes two parameters: maxOccupants, which is an int, and maxWeight, which is a double.
        //o Creates new memory for the Occupants array to be the size of maxOccupants.
        //o Assigns MaxWeight the value of maxWeight.
        // Three public methods:
        //o AddOccupant
        // Takes two parameters: passenger, which is a Passenger, and index, which is an int.
        // Assigns Occupants at position index the value of passenger.
        // No return value. (void)
        //o GetCurrentWeight, which returns the sum of the weights of all occupants in this Elevator.
        //o IsOverMaxCapacity, which returns whether or not GetCurrentWeight is greater than MaxWeight.
    }
}
