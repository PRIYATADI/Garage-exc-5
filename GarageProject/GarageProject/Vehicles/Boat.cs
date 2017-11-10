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
        private bool withoutMotor;

        public bool WithMotor { set { withMotor = value; } get { return withMotor; } }
        public bool WithoutMotor { set { withoutMotor = value; } get {return withoutMotor; } }

        public Boat()
        {

        }

        public Boat(int id, string fName, string lName, string registrationNumber, string type, string model,
            string color, DateTime parkingtime, DateTime unparktime, float parkingperiod, bool withMotor, bool withoutMotor):
            base(id, fName, lName, registrationNumber, type, model,
            color, parkingtime, unparktime, parkingperiod)
        {
            WithMotor = withMotor;
            WithoutMotor= withoutMotor;
        }
    }
}
