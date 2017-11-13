using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Moped : Vehicle
    {
        private int length;
        private string fuelType;

        public int Length { set { length = value; } get { return length; } }
        public string FuelType { set { fuelType = value; } get { return fuelType; } }
        public Moped()
        {

        }

        public Moped(int id, string fName, string lName, string registrationNumber,  string type, string model, string color,int numberOfWheels, 
            int numberOfSeats, int numberOfEngines, DateTime parkingTime, DateTime unparkTime, float parkingperiod,int lenght, string fuelType) :
            base(id, fName, lName, registrationNumber, type, model,
            color, numberOfWheels, numberOfSeats, numberOfEngines, parkingTime, unparkTime, parkingperiod)
        {
            Length = length;
            FuelType = fuelType;
        }
        public override string VehicleInformations()
        {
            return base.VehicleInformations() + "\n Length is: " + Length + "\n  Fuel Type is: " + FuelType;
        }
    }
}
