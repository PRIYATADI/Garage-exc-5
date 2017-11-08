using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
   public class Airplane:Vehicle
    {
        private int length_of_wing;
        public int Length_Of_Wing { get; set; }

        public Airplane()
        {

        }

        public Airplane(int registration_number, string color, int number_of_wheels, int model, int length_of_wing):
            base(registration_number, color, number_of_wheels, model)
        {
            Length_Of_Wing= length_of_wing;
            Console.ReadLine();
        }
    }
}
