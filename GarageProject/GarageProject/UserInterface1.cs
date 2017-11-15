using GarageProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    class UserInterface1:Vehicle
    {
        //Set maximum Capacity Of The Garage
        public int MaximumRequiredCapacity;
        private Garage<Vehicle> entireCapacity;

        //Create a new garage with a specific size
        public void CreateTheSizeOfTheGarage()
        {
            
        }

        public void CreateNewGarage()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n*******************************Create Garage*********************************\n");
                Console.WriteLine("Only the administrator of the garage has the right of doing creating a garage");
                Console.WriteLine("\n*****************************************************************************\n");
                Console.WriteLine(" Type the capacity of the Garage, please.");
                string sMaximumSetCapacity = Console.ReadLine();
                while (!int.TryParse(sMaximumSetCapacity, out MaximumRequiredCapacity))
                {
                    if (MaximumRequiredCapacity <= 0)
                    {
                        Console.WriteLine("Invalid input, try again, please!");
                    }
                    else//???
                    sMaximumSetCapacity = Console.ReadLine();
                }
                entireCapacity = new Garage<Vehicle>(MaximumRequiredCapacity);
                Console.ReadLine();
                Console.WriteLine("Press 0 to return to the main menu, please!");
                Console.WriteLine("Press 2 to recreate the garage");
                string newInput = Console.ReadLine();
                switch (newInput)
                {
                    case "2":
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            }
        }
    }
}