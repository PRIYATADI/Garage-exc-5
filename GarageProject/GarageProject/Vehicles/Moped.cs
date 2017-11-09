using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Moped : Vehicle
    {
        private int length;

        public int Length { set { length = value; } get { return length; } }
    }
}
