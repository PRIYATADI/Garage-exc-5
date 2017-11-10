

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
        //private int numberOfWheels;
        //// private   
        //public  int numberOfSeats;
        //private int numberOfEngines;
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
        //public int NumberOfWheels { set { numberOfWheels = value; } get { return numberOfWheels; } }
        //public int NumberOfSeats { set { numberOfSeats = value; } get { return numberOfSeats; } }
        //public int NumberOfEngines { set { numberOfEngines = value; } get { return numberOfEngines; } }
        public DateTime ParkingTime { set { parkingTime = value; } get { return parkingTime; } }
        public DateTime UnparkingTime { set { unparkingTime = value; } get { return unparkingTime; } }
        public float ParkingPeriod { set { parkingPeriod = value; } get { return parkingPeriod; } }

        public Vehicle()
        {

        }

        public Vehicle(int id, string fName, string lName, string registrationNumber, string type,string model,
            string color,DateTime parkingtime,DateTime unparktime,float parkingperiod)
        {
            Id = id;
            TheOwnerFName = fName;
            TheOwnerLName = lName;
            RegistrationNumber = registrationNumber;
            Type = type;
            Model = model;
            Color = color;
            ParkingTime = parkingtime;
            UnparkingTime = unparktime;
            ParkingPeriod = parkingperiod;
            //NumberOfWheels = numberOfWheels;
            //NumberOfSeats = numberOfSeats;
            //NumberOfEngines = numberOfEngines;
        }

       
        public string PrintParkedVehicle()
        {
            return "Id:" + Id + "\nTheOwnerFName:" + TheOwnerFName + "\nTheOwnerLName:" + TheOwnerLName +
                "\nRegistrationNumber:" + RegistrationNumber + "\nType:" + Type + "\nModel:" + Model + "\nColor:" + Color +
                "\nParkingTime:" + ParkingTime + "\nUnparkingTime:" + UnparkingTime + "\nParkingPeriod" + ParkingPeriod;
        }


      
    }
}
