using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicle
{
    public class Airplane : Vehicle
    {
        private int wingsLength;

        public int WingsLength { set { wingsLength = value; } get { return wingsLength; } }
     }
}
