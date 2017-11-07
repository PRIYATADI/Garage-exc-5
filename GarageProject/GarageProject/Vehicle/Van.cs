using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicle
{
    public class Van: Vehicle
    {
        private bool withcabin;

        public bool Withcabin { set { withcabin = value; } get { return withcabin; } }
    }
}
