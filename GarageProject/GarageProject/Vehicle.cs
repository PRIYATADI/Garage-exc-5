
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Vehicle
    {
        private int id;
        private string theOwnerFName;
        private string theOwnerLName;
        private string registrationNumber;
        private string type;
        private string model;
        private string color;
        private int numberOfWheels;
        public int numberOfSeats;
        private int numberOfEngines;
        private DateTime parkingTime;
        private DateTime unparkingTime;
        private float parkingPeriod;
       

        public int Id { set { id = value; } get { return id; } }
        public string TheOwnerFName { set { theOwnerFName = value; } get { return theOwnerFName; } }
        public string TheOwnerLName { set { theOwnerLName = value; } get { return theOwnerLName; } }
        public string RegistrationNumber { set { registrationNumber = value; } get { return registrationNumber; } }
        public string Type { set { type = value; } get { return type; } }
        public string Model { set { model = value; } get { return model; } }
        public string Color { set { color = value; } get { return color; } }
        public int NumberOfWheels { set { numberOfWheels = value; } get { return numberOfWheels; } }
        public int NumberOfSeats { set { numberOfSeats = value; } get { return numberOfSeats; } }
        public int NumberOfEngines { set { numberOfEngines = value; } get { return numberOfEngines; } }
        public DateTime ParkingTime { set { parkingTime = value; } get { return parkingTime; } }
        public DateTime UnparkingTime { set { unparkingTime = value; } get { return unparkingTime; } }
        public float ParkingPeriod { set { parkingPeriod = value; } get { return parkingPeriod; } }

        

        public void SetId(Vehicle veh, int id)
        {
            veh.Id = id;
        }
        public void SetTheOwnerFName(Vehicle veh, string fName)
        {
            veh.TheOwnerFName = fName;
        }
        public void SetTheOwnerLName(Vehicle veh, string lName)
        {
            veh.TheOwnerLName = lName;
        }
        public void SetRegistrationNumber(Vehicle veh, string registrationNumber)
        {
            veh.RegistrationNumber = registrationNumber;
        }
        public void SetType(Vehicle veh, string type)
        {
            veh.Type = type;
        }
        public void SetModel(Vehicle veh, string model)
        {
            veh.Model = model;
        }
        public void SetColor(Vehicle veh, string color)
        {
            veh.Color = color;
        }
        public void SetNumberOfWheels(Vehicle veh, int numberOfWheels)
        {
            veh.NumberOfWheels = numberOfWheels;
        }
        public void SetGetNumberOfSeats(Vehicle veh, int numberOfSeats)
        {
            veh.NumberOfSeats = numberOfSeats;
        }
        public void SetNumberOfEngines(Vehicle veh, int numberOfEngines)
        {
            veh.NumberOfEngines = numberOfEngines;
        }
        public void SetParkingTime(Vehicle veh, DateTime parkingTime)
        {
            veh.ParkingTime = parkingTime;
        }
        public void SetUnparkingTime(Vehicle veh, DateTime unParkingTime)
        {
            veh.UnparkingTime = unparkingTime;
        }
        public void SetParkingPeriod(Vehicle veh, float parkingPeriod)
        {
            veh.ParkingPeriod = parkingPeriod;
        }

        public int GetId(Vehicle veh)
        {
            return veh.Id;
        }
        public string GetTheOwnerFName(Vehicle veh)
        {
            return veh.TheOwnerFName;
        }
        public string GetTheOwnerLName(Vehicle veh)
        {
            return veh.TheOwnerLName;
        }
        public string GetRegistrationNumber(Vehicle veh)
        {
            return veh.RegistrationNumber;
        }
        public string GetType(Vehicle veh)
        {
            return veh.Type;

        }
        public string GetModel(Vehicle veh, string model)
        {
            return veh.Model;
        }
        public string GetColor(Vehicle veh)
        {
            return veh.Color;
        }
        public int GetNumberOfWheels(Vehicle veh)
        {
            return veh.NumberOfWheels;
        }
        public int GetNumberOfSeats(Vehicle veh)
        {
            return veh.NumberOfSeats;
        }
        public int GetNumberOfEngines(Vehicle veh)
        {
            return veh.NumberOfEngines;
        }
        public DateTime GetParkingTime(Vehicle veh)
        {
            return veh.ParkingTime;
        }
        public DateTime GetUnparkingTime(Vehicle veh)
        {
            return veh.UnparkingTime;
        }
        public float GetParkingPeriod(Vehicle veh)
        {
            return veh.ParkingPeriod;
        }

        public Vehicle()
        {

        }

        public Vehicle (int id, string fName, string lName, string registrationNumber,  string color, string type, 
                        string model, int numberOfWheels, int numberOfSeats, int numberOfEngines, DateTime parkingTime,
                        DateTime unparkingTime, float parkingPeriod)
        {
            Id = id;
            TheOwnerFName = fName;
            TheOwnerLName = lName;
            RegistrationNumber = registrationNumber;
            Type = type;
            Color = color;
            NumberOfWheels = numberOfWheels;
            NumberOfSeats = numberOfSeats;
            NumberOfEngines = numberOfEngines;
            ParkingTime = parkingTime;
            UnparkingTime = unparkingTime;
            ParkingPeriod = parkingPeriod;
        }

        public virtual string VehicleInformations()
        {
         return "Id: " + Id + "\nThe owner family name: " + TheOwnerFName + "\nThe owner name:  " + TheOwnerLName +
                "\nRegistration Number: " + RegistrationNumber + "\nType: " + Type + "\nColor: " + Color +
                "\nModel: " + Model + "\nNumber Of Wheels: " + NumberOfWheels + "\nNumber Of Seats: " + NumberOfSeats +
                "\nNumber Of Engines: " + NumberOfEngines + "\nParking Time: " + ParkingTime +
                "\nUnParking Time: " + UnparkingTime + "\nParking Period: " + ParkingPeriod;
        }
        
        public virtual string FindVehicleInformations()
        {
            return "\n************************************************************************************************\n" +
                   "\n________________________________________________________________________________________________\n" +
                   "This vehicle has the following informations: \nId: " + Id + "\nThe owner family name: " + TheOwnerFName +
                   "\nThe owner name:  " + TheOwnerLName + "\nRegistration Number: " + RegistrationNumber + "\nType: " + Type +
                   "\nColor: " + Color + "\nModel: " + Model + "\nNumber Of Wheels: " + NumberOfWheels + "\nNumber Of Seats: " + NumberOfSeats +
                   "\nNumber Of Engines: " + NumberOfEngines + "\nParking Time: " + ParkingTime +
                   "\nUnParking Time: " + UnparkingTime + "\nParking Period: " + ParkingPeriod +
                   "\n________________________________________________________________________________________________\n" +
                   "\n************************************************************************************************\n";
        }
    }
}