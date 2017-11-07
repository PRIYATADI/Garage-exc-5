using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicle
{
    public class Motorcycle : Vehicle
    {
        private int speed;

        public int Speed { set { speed = value; } get { return speed; } }
    }
}
