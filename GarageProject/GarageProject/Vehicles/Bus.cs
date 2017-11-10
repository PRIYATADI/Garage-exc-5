using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Bus : Vehicle
    {
        private int numberOfSeats;
        private int height;

        public int NumberOfSeats {set { numberOfSeats = value; } get { return numberOfSeats; } }
        public int Height { set { height = value; } get { return height; } }

        public Bus()
        {

        }

        public Bus(int id, string fName, string lName, string registrationNumber, string type, string model,
            string color, DateTime parkingtime, DateTime unparktime, float parkingperiod, int numberOfSeats, int height):
            base(id, fName, lName, registrationNumber, type, model,
            color, parkingtime, unparktime, parkingperiod)
        {
            NumberOfSeats = numberOfSeats;
            Height = height;

        }
    }
}
