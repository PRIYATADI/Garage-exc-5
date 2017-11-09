using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public  class Car : Vehicle
    {
        private bool decapotabil;

        public bool Decapotabil { set { decapotabil = value; } get { return decapotabil; } }
    }
}
