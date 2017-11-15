using GarageProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public /*abstract */class GarageHandler
    {
        private int maximumSetCapacity;

        public int MaximumSetCapacity { get { return maximumSetCapacity; } set { maximumSetCapacity = value; } }

        SetMaximumCapacityOfTheGarage()
        {
            Garage<Vehicle> MaxSetCapacity = new Garage<Vehicle>(MaximumSetCapacity);
        }
    }

}

////public void MainMenu()
////            {
              ////                   // foreach (var vehic in garage)
////                {
//                //    Console.WriteLine(vehic.PrintRace() + "\n--------------------------------\n");
//                }
//                Console.ReadLine();
//                Console.Clear();
//               // Console.WriteLine(garage.OrderByDescending(x => x.Strength).FirstOrDefault().PrintRace());

//                Console.ReadLine();
//                Console.Clear();

//               // foreach (var race in garage.Where(x => x.Name.ToUpper().Contains("A") || x.Intelligence < 80).OrderBy(x => x.Name).OrderBy(x => x.Charisma))
//                {
//                 //   Console.WriteLine(race.PrintRace() + "\n--------------------------------\n");
//                }

//                //Console.WriteLine(human.CalculateNumberOfLanguages());
//                Console.ReadLine();
            