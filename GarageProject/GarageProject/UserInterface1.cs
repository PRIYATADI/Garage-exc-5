
using GarageProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    class UserInterface1 : Vehicle
    {
        //Set maximum Capacity Of The Garage
        public int MaximumRequiredCapacity;
        private Garage<Vehicle> entireCapacity;

        public void CreateSubMenu()
        {
            public void CreateNewGarage()
            {
                Console.Clear();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n*************************Create Garage***************************\n");

                    Console.WriteLine(" Type the capacity of the Garage, please.");
                    string sMaximumSetCapacity = Console.ReadLine();
                    while (!int.TryParse(sMaximumSetCapacity, out MaximumRequiredCapacity))
                    {
                        if (MaximumRequiredCapacity <= 0)
                        {
                            Console.WriteLine("Invalid input, try again, please!");
                        }
                        sMaximumSetCapacity = Console.ReadLine();
                    }
                    entireCapacity = new Garage<Vehicle>(MaximumRequiredCapacity);
                    Console.ReadLine();
                    Console.WriteLine("Press 0 to return to the main menu, please!");
                    Console.WriteLine("Press 2 to recreate the garage");
                    string newInput= Console.ReadLine();
                    switch (newInput)
                    {
                        case "2";
                            break;
                        case "0";
                            return;
                        default:
                            break;
                    }

                }


            }


        }
    }
}

