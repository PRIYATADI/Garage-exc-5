using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    class Program
    {
        static void Main(string[] args)
        {

        //    public void MainMenu()
        //{

            GarageHandler vehicle = new GarageHandler();
            List < Vehicle > vehicleList = new List<Vehicle>();
            vehicleList.Add(vehicle.CreateParkedVehicle( "Car", "Billy", "Ceaser", "BUH 170", "red", 4, 2, 1,10 ));
            vehicleList.Add(vehicle.CreateParkedVehicle("Airplain", "Bhanu", "Vakamalla", " ", "black", 150, 58, 2, 9));
            vehicleList.Add(vehicle.CreateParkedVehicle("Helicopter", "Sai", "Bodimallu",  " ","white",   170, 70, 3, 5));
            vehicleList.Add(vehicle.CreateParkedVehicle("Moped", "Tanishca", "Bodimallu",  " ", "blue", 120, 25, 1, 6));
            vehicleList.Add(vehicle.CreateParkedVehicle("Boat", "Varnica", "Bodimallu", " ", "green", 80, 12, 4, 8));
            //"Lamborgini"
            //(Vehicle veh, string fName, string lName, string registrationNumber, string type, string color, int numberOfWheels, int numberOfSeats, int numberOfEngines, DateTime parkingTime)
            foreach (Vehicle v in vehicleList)
                            {
                Console.WriteLine(vehicle.PrintParkedVehicle(v));
                            }
            
            Console.ReadLine(); ;

        }
        }
    }
}
