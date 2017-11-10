//using GarageProject.Vehicle;
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
           
           //public abstract  void MainMenu();

            {
             UserInterface control = new UserInterface();
                control.CreateMainMenu();
            }
            {
                //Vehicle printList = new Vehicle();
                //printList.PrintParkedVehicle(Vehicle veh);
            }

            //Vehicle vehicle = new Vehicle();
            //List<Vehicle> vehicleList = new List<Vehicle>();
            //vehicleList.Add(vehicle.CreateParkedVehicle(6, "Car", "Billy", "Ceaser", "BUH 170", "red", 4, 2, 1));
            //vehicleList.Add(vehicle.CreateParkedVehicle(78, "Airplain", "Bhanu", "Vakamalla", " ", "black", 150, 58, 2));
            //vehicleList.Add(vehicle.CreateParkedVehicle(198, "Helicopter", "Sai", "Bodimallu", " ", "white", 170, 70, 3));
            //vehicleList.Add(vehicle.CreateParkedVehicle(34, "Moped", "Tanishca", "Bodimallu", " ", "blue", 120, 25, 1));
            //vehicleList.Add(vehicle.CreateParkedVehicle(111, "Boat", "Varnica", "Bodimallu", " ", "green", 80, 12, 4));

            ////"Lamborgini"
            ////(Vehicle veh, int id, string fName, string lName, string registrationNumber, string type, string color, int numberOfWheels, int numberOfSeats, int numberOfEngines, DateTime parkingTime)

            //foreach (Vehicle v in vehicleList)
            //{
            //    Console.WriteLine(vehicle.PrintParkedVehicle(v));
            //}

            Console.ReadLine();


        }
    }
  }
    