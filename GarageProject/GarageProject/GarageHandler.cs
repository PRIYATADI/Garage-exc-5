
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
     public /*abstract */class GarageHandler
    {













        public Vehicle CreateParkedVehicle(int id, string type, string fName, string lName, string registrationNumber, string color, int numberOfWheels, int numberOfSeats, int numberOfEngines /*DateTime parkingTime*/)
        {
            Vehicle alfa = new Vehicle();
            alfa.Id = id;
            alfa.TheOwnerFName = fName;
            alfa.TheOwnerLName = lName;
            alfa.RegistrationNumber = registrationNumber;
            alfa.Type = type;
            alfa.Color = color;
            alfa.NumberOfWheels = numberOfWheels;
            alfa.NumberOfSeats = numberOfSeats;
            alfa.NumberOfEngines = numberOfEngines;
            //alfa.ParkingTime = parkingTime;
            return alfa;
        }

        public string PrintParkedVehicle(Vehicle veh)
        {
            return "The owner name: " + veh.TheOwnerFName + " " + veh.TheOwnerLName +
                   "\nRegistration Number: " + veh.RegistrationNumber + "\nType: " + veh.Type +
                   "\nColor: " + veh.Color + "\nNumber Of Wheels: " + veh.NumberOfWheels +
                    "\nNumber Of Seats: " + veh.NumberOfSeats + "\nNumber Of Engines: " + veh.NumberOfEngines +
                    "\nParking Time: " + veh.ParkingTime;

        }

    //        GarageHandler vehicle = new GarageHandler();
    //        List<Vehicle> vehicleList = new List<Vehicle>();
    //        vehicleList.Add(vehicle.CreateParkedVehicle(6, "Car", "Billy", "Ceaser", "BUH 170", "red", 4, 2, 1));
    //        vehicleList.Add(vehicle.CreateParkedVehicle(78, "Airplain", "Bhanu", "Vakamalla", " ", "black", 150, 58, 2));
    //        vehicleList.Add(vehicle.CreateParkedVehicle(198, "Helicopter", "Sai", "Bodimallu", " ", "white", 170, 70, 3));
    //        vehicleList.Add(vehicle.CreateParkedVehicle(34, "Moped", "Tanishca", "Bodimallu", " ", "blue", 120, 25, 1));
    //        vehicleList.Add(vehicle.CreateParkedVehicle(111, "Boat", "Varnica", "Bodimallu", " ", "green", 80, 12, 4));

    //        //"Lamborgini"
    //        //(Vehicle veh, int id, string fName, string lName, string registrationNumber, string type, string color, int numberOfWheels, int numberOfSeats, int numberOfEngines, DateTime parkingTime)

    //        foreach (Vehicle v in vehicleList)
    //        {
    //            Console.WriteLine(vehicle.PrintParkedVehicle(v));
    //        }

    
    }
}
