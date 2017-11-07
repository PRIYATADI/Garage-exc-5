using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
   public class Caravan : Vehicle
    {
        private int how_many_rooms;
        public int How_Many_Rooms { get; set; }

        public Caravan()
        {
                
        }
         public Caravan(int registration_number, string color, int number_of_wheels, int model, int how_many_rooms):
            base(registration_number, color, number_of_wheels, model)
        {
            How_Many_Rooms = how_many_rooms;
        }

    }
}
