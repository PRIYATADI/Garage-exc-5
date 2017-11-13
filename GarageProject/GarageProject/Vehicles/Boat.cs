using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Boat : Vehicle
    {
        private bool withMotor;
        private bool withCatarg;

        public bool WithMotor { set { withMotor = value; } get { return withMotor; } }
        public bool WithCatarg { set { withCatarg = value; } get { return withCatarg; } }
        public Boat()
        {

        }

        public Boat(int id, string fName, string lName, string registrationNumber, string type, string model, int numberOfWheels, int numberOfSeats, int numberOfEngines,
            string color, DateTime parkingTime, DateTime unparkingTime, float parkingPeriod, bool withMotor, bool withCatarg) :
            base(id, fName, lName, registrationNumber, type, model,
            color, numberOfWheels, numberOfSeats, numberOfEngines, parkingTime, unparkingTime, parkingPeriod)
        {
            WithMotor = withMotor;
            WithCatarg = withCatarg;
        }

        public override string VehicleInformations()
        {
            return base.VehicleInformations() + "\n with Motor: " + WithMotor + "\nwithCatarg: " + WithCatarg;
        }

    }

}
