

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
        // private   
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

        //public Vehicle CreateParkedVehicle(int id, string type, string fName, string lName, string registrationNumber, string color, string model, int numberOfWheels, int numberOfSeats, int numberOfEngines /*DateTime parkingTime*/)
        //{
        //    Vehicle alfa = new Vehicle();
        //    alfa.Id = id;
        //    alfa.TheOwnerFName = fName;
        //    alfa.TheOwnerLName = lName;
        //    alfa.RegistrationNumber = registrationNumber;
        //    alfa.Type = type;
        //    alfa.Color = color;
        //    alfa.NumberOfWheels = numberOfWheels;
        //    alfa.NumberOfSeats = numberOfSeats;
        //    alfa.NumberOfEngines = numberOfEngines;
        //    //alfa.ParkingTime = parkingTime;
        //    return alfa;
        //}

        //public string PrintParkedVehicle(Vehicle veh)
        //{
        //    return "The owner name: " + veh.TheOwnerFName + " " + veh.TheOwnerLName +
        //           "\nRegistration Number: " + veh.RegistrationNumber + "\nType: " + veh.Type +
        //           "\nColor: " + veh.Color + "\nNumber Of Wheels: " + veh.NumberOfWheels +
        //            "\nNumber Of Seats: " + veh.NumberOfSeats + "\nNumber Of Engines: " + veh.NumberOfEngines +
        //            "\nParking Time: " + veh.ParkingTime;

        //}

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
        public void SetUnparkingTime(Vehicle veh, DateTime unparkingTime)
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

        public Vehicle CreateParkedVehicle(int id, string type, string fName, string lName, string registrationNumber, string color, string model, int numberOfWheels, int numberOfSeats, int numberOfEngines /*DateTime parkingTime*/)
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
                   "\nColor: " + veh.Color + "\nModel: " + veh.Model +
                    "\nNumber Of Wheels: " + veh.NumberOfWheels + "\nNumber Of Seats: " + veh.NumberOfSeats +
                    "\nNumber Of Engines: " + veh.NumberOfEngines + "\nParking Time: " + veh.ParkingTime;
        }

    }
       
}
