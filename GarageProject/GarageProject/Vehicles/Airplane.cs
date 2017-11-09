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

        public int WingsLength { set { wingsLength = value; } get { return wingsLength; } }
     }
}
