using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicle
{
    public class Helicopter : Vehicle
    {
        private int helicSpeed;

        public int HelicSpeed { set { helicSpeed = value; } get { return helicSpeed; } }
    }
}
