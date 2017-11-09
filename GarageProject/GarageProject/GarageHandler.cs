
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
     public /*abstract */class GarageHandler
    {

        //public void SetId(Vehicle veh, int id)
        //{
        //    veh.Id = id;
        //}
        //public void SetTheOwnerFName(Vehicle veh, string fName)
        //{
        //    veh.TheOwnerFName = fName;
        //}
        //public void SetTheOwnerLName(Vehicle veh, string lName)
        //{
        //    veh.TheOwnerLName = lName;
        //}
        //public void SetRegistrationNumber(Vehicle veh, string registrationNumber)
        //{
        //    veh.RegistrationNumber=registrationNumber;
        //}
        //public void SetType(Vehicle veh, string type)
        //{
        //    veh.Type = type;
        //}
        //public void SetColor(Vehicle veh, string color)
        //{ 
        //    veh.Color=color;
        //}
        //public void SetNumberOfWheels(Vehicle veh, int numberOfWheels)
        //{
        //    veh.NumberOfWheels = numberOfWheels;
        //}
        //public void SetGetNumberOfSeats(Vehicle veh, int numberOfSeats)
        //{
        //    veh.NumberOfSeats = numberOfSeats;
        //}
        //public void SetNumberOfEngines(Vehicle veh, int numberOfEngines)
        //{
        //    veh.NumberOfEngines = numberOfEngines;
        //}
        //public void SetParkingTime(Vehicle veh, DateTime parkingTime)
        //{
        //    veh.ParkingTime = parkingTime;
        //}
        //public void SetUnparkingTime(Vehicle veh, DateTime unparkingTime)
        //{
        //    veh.UnparkingTime = unparkingTime;
        //}
        //public void SetParkingPeriod(Vehicle veh, float parkingPeriod)
        // {
        //    veh.ParkingPeriod = parkingPeriod; 
        // }

        //public int GetId(Vehicle veh)
        //{
        //    return veh.Id;
        //}
        //public string GetTheOwnerFName(Vehicle per)
        //{
        //   return per.FName;
        //}
        //public string GetTheOwnerLName(Vehicle per)
        //{
        //    return per.LName;
        //}
        //public string GetRegistrationNumber(Vehicle veh)
        //{
        //    return veh.RegistrationNumber;
        //}
        //public void GetType(Vehicle veh)
        //{
        //    return veh.Type;
        //}
        //public string GetColor(Vehicle veh)
        //{
        //    return veh.Color;
        //}
        //public int GetNumberOfWheels(Vehicle veh)
        //{
        //    return veh.NumberOfWheels;
        //}
        //public int GetNumberOfSeats(Vehicle veh)
        //{
        //    return veh.NumberOfSeats;
        //}
        //public int GetNumberOfEngines(Vehicle veh)
        //{
        //    return veh.NumberOfEngines;
        //}
        //public DateTime GetParkingTime(Vehicle veh)
        //{
        //    return veh.ParkingTime;
        //}
        //public DateTime GetUnparkingTime(Vehicle veh)
        //{
        //    return veh.UnparkingTime;
        //}
        //public float GetParkingPeriod(Vehicle veh)
        //{
        //    return veh.ParkingPeriod;
        //}

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

    //Console.ReadLine();
        //public Garage CreateGarage[20000]()

        // Vehicle veh
        // Console.WriteLine(Garage.Array.GetCapacity());
    }
}
