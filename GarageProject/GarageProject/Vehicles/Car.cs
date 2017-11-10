using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public  class Car : Vehicle
    {
        private bool automatic ;
        private bool gear;

        public bool Automatic { set { automatic = value; } get { return automatic; } }
        public bool Gear { set { gear = value; } get { return gear; } }

        public Car()
        {

        }

        public Car(int id, string fName, string lName, string registrationNumber, string type, string model,
            string color, DateTime parkingtime, DateTime unparktime, float parkingperiod, bool automatic, bool gear):
            base(id, fName, lName, registrationNumber, type, model,
            color, parkingtime, unparktime, parkingperiod)
        {
            Automatic = automatic;
            Gear = gear;
        }
    }
}
