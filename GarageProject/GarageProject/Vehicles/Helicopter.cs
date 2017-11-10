using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Helicopter : Vehicle
    {
        private string helicType;

        public string HelicType { set { helicType = value; } get { return helicType; } }
    }
}
