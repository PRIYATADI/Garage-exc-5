using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
   public class Boat:Vehicle
    {
        private int number_of_motor;
        public int Number_Of_Motor { get; set; }

        public Boat()
        {

        }

        public Boat(int registration_number, string color, int number_of_wheels, int model, int number_of_motor):
            base(registration_number, color, number_of_wheels, model)
        {
            Number_Of_Motor= number_of_motor;
        }

    }
}
