using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Van: Vehicle
    {
        private bool withSpecialPlacesForChildren;
        public bool WithSpecialPlacesForChildren { set { withSpecialPlacesForChildren = value; } get { return withSpecialPlacesForChildren; } }

        public Van()
        {

        }

        public Van(int id, string fName, string lName, string registrationNumber, string type, string model,
                   int numberOfWheels, int numberOfSeats, int numberOfEngines, string color, DateTime parkingTime,
                   DateTime unparkingTime, float parkingPeriod, bool withSpecialPlacesForChildren) :
        base(id, fName, lName, registrationNumber, type, model, color, numberOfWheels, numberOfSeats,
            numberOfEngines, parkingTime, unparkingTime, parkingPeriod)

        {
          WithSpecialPlacesForChildren = withSpecialPlacesForChildren;
        }

        public override string VehicleInformations()
        {
          return base.VehicleInformations() + "\nWith Special Places For Children: " + WithSpecialPlacesForChildren;
        }
    }
}