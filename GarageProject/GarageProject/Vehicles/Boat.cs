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

        public bool WithMotor { set { withMotor = value; } get { return withMotor; } }
    }
}
