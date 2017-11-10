using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Moped : Vehicle
    {
        private int numberOfWheels;
        private string fuelType;

        public int NumberOfWheels { set { numberOfWheels = value; } get { return numberOfWheels; } }
        public string FuelType { set { fuelType = value; } get { return fuelType; } }

        public Moped()
        {

        }

        public Moped(int id, string fName, string lName, string registrationNumber, string type, string model,
            string color, DateTime parkingtime, DateTime unparktime, float parkingperiod, int numberOfWheels, string fuelType):
            base(id, fName, lName, registrationNumber, type, model,
            color, parkingtime, unparktime, parkingperiod)
        {
            NumberOfWheels= numberOfWheels;
            FuelType= fuelType;
        }
    }
}
