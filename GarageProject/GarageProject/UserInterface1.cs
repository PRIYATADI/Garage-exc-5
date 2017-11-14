
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
        public void CreateNewGarage()
        { 
       
        {
         //Set Maximum Capacity Of The Garage
            { 
            Console.WriteLine(" Type the capacity of the Garage, please.");
            int maximumSetCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ***********************************************************\n");
            Console.WriteLine( "New Garage created with a capacity of: " + maximumSetCapacity
                                + "vehicles");
            Console.WriteLine("\n ***********************************************************\n");
            Console.ReadLine();
            }
        }
        }
    }
}
