using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Vehicle
    {
        private string theOwnerFName;
        private string theOwnerLName;
        private string registrationNumber;
        private string type;
        private string color;
        private int numberOfWheels;
        private int numberOfSeats;
        private int numberOfEngines;
        private DateTime parkingTime;
        private DateTime unparkingTime;
        private float parkingPeriod;

        public string TheOwnerFName { set { theOwnerFName = value; } get { return theOwnerFName; } }
        public string TheOwnerLName { set { theOwnerLName = value; } get { return theOwnerLName; } }
        public string RegistrationNumber { set { registrationNumber = value; } get { return registrationNumber; } }
        public string Type { set { type = value; } get { return type; } }
        public string Color { set { color = value; } get { return color; } }
        public int NumberOfWheels { set { numberOfWheels = value; } get { return numberOfWheels; } }
        public int NumberOfSeats { set { numberOfSeats = value; } get { return numberOfSeats; } }
        public int NumberOfEngines { set { numberOfEngines = value; } get { return numberOfEngines; } }
        public DateTime ParkingTime { set { parkingTime = value; } get { return parkingTime; } }
        public DateTime UnparkingTime { set { unparkingTime = value; } get { return unparkingTime; } }
        public float ParkingPeriod { set { parkingPeriod = value; } get { return parkingPeriod; } }


    
    }
}
