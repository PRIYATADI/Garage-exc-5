using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Bus:Vehicle
    {
        private int number_of_seats;
        public int Number_Of_Seats { get; set; }

        public Bus()
        {

        }

        public Bus(int registration_number, string color, int number_of_wheels, int model,int number_of_seats) :
            base(registration_number, color, number_of_wheels, model)
        {
            Number_Of_Seats= number_of_seats;
            Console.ReadLine();
        }

    }
}
