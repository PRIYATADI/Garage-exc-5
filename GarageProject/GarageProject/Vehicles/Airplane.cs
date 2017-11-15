using GarageProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Airplane : Vehicle
    {
        private float wingsLength;
        private int numberOfWindoors;

        public float WingsLength { set { wingsLength = value; } get { return wingsLength; } }
        public int NumberOfWindoors { set { numberOfWindoors = value; } get { return numberOfWindoors; } }

        public Airplane()
        {

        }

        public Airplane(int id, string fName, string lName, string registrationNumber, string type, string model, 
                        int numberOfWheels, int numberOfSeats, int numberOfEngines, string color, DateTime parkingTime, 
                        DateTime unparkingTime, float parkingPeriod, float wingsLength, int numberOfWindoors) :
        base(id, fName, lName, registrationNumber, type, model, color, numberOfWheels,
             numberOfSeats, numberOfEngines, parkingTime, unparkingTime, parkingPeriod)
        {
            WingsLength = wingsLength;
            NumberOfWindoors = numberOfWindoors;
        }

        public override string VehicleInformations()
        {            
        return base.VehicleInformations() + "\nWings Length is: " + WingsLength + "\nNumber of Windoors is: " + NumberOfWindoors;
        }
    }
}