using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Airplane : Vehicle
    {
        private int wingsLength;
        private int numberOfWindoors;

        public int WingsLength { set { wingsLength = value; } get { return wingsLength; } }
        public int NumberOfWindoors { set { numberOfWindoors = value; } get { return numberOfWindoors; } }

        public Airplane()
        {

        }
        public Airplane(int id, string fName, string lName, string registrationNumber, string type, string model,
            string color, DateTime parkingtime, DateTime unparktime, float parkingperiod, int wingsLength, int numberOfWindoors) :
            base( id,  fName,  lName, registrationNumber,  type,  model,
            color,  parkingtime, unparktime,  parkingperiod)
            {
                WingsLength = wingsLength;
                NumberOfWindoors = numberOfWindoors;
            }
     }
}
