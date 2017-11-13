using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Van: Vehicle
    {
        private bool withSpecialCabin;
       
        public bool WithSpecialCabin { set { withSpecialCabin = value; } get { return withSpecialCabin; } }

        public Van()
        {

        }

        public Van(int id, string fName, string lName, string registrationNumber, string type, string model, int numberOfWheels, int numberOfSeats, int numberOfEngines,
            string color, DateTime parkingTime, DateTime unparkingTime, float parkingPeriod, bool withSpecialCabin):
         base(id, fName, lName, registrationNumber, type, model, color, numberOfWheels,
            numberOfSeats, numberOfEngines, parkingTime, unparkingTime, parkingPeriod)

        {
            WithSpecialCabin = withSpecialCabin;
          
        }

        public override string VehicleInformations()
        {
            return base.VehicleInformations() + "\nWith Special Cabin: " + WithSpecialCabin;
        }
    }
}
