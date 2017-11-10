using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Helicopter : Vehicle
    {
        private int numberOfWings ;
        private int weidth;

        public int NumberOfWings { set { numberOfWings = value; } get { return numberOfWings; } }
        public int Weidth { set { weidth = value; } get { return weidth; } }

        public Helicopter()
        {

        }

        public Helicopter(int id, string fName, string lName, string registrationNumber, string type, string model,
            string color, DateTime parkingtime, DateTime unparktime, float parkingperiod, int numberOfWings, int weidth):
            base(id, fName, lName, registrationNumber, type, model,
            color, parkingtime, unparktime, parkingperiod)
        {
            NumberOfWings= numberOfWings;
            Weidth= weidth;

        }
    }
}
