using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicle
{
    public class Bus : Vehicle
    {
        private int hight;

        public int Hight { set { hight = value; } get { return hight; } }
    }
}
