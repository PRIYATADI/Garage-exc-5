﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Bus : Vehicle
    {
        private float height;
        private int numberOfDoubleSeats;

        public float Height { set { height = value; } get { return height; } }
        public int NumberOfDoubleSeats { set { numberOfDoubleSeats = value; } get { return numberOfDoubleSeats; } }

        public Bus()
        {

        }

        public Bus(int id, string fName, string lName, string registrationNumber, string color, string type, string model,
            int numberOfWheels, int numberOfSeats, int numberOfEngines, DateTime parkingTime, DateTime unparkTime, float parkingPeriod, 
            int numberOfDoubleSeats, float height) :
            base(id, fName, lName, registrationNumber, type, model,
            color, numberOfWheels, numberOfSeats, numberOfEngines, parkingTime, unparkTime, parkingPeriod)

        {
            Height = height;
            NumberOfDoubleSeats = numberOfDoubleSeats;
        }
    public override string VehicleInformations()
    {
        return base.VehicleInformations() + "\nHeight : " + Height + "\nNumberOfDoubleSeats: " + NumberOfDoubleSeats;
    }

}
}
