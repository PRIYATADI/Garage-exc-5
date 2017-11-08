using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Garage<T> where T : Vehicle
    {
        public int NextId = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<T> Vehicles { get; set; }

        private int nextId = 0;

        public Garage(string name)
        {
            this.Id = NextId++;
            this.Name = name;
            this.Vehicles = new List<T>();
        }

        public Garage() : this("")
        {
        }



        public override string ToString()
        {

            return string.Format("{0, 0}{1, 30} {2, 5}", Id, Name, Vehicles.Count);
        }

    }
}
        //private string[] Type_Of_Vehical = new string[6];
        //private string[] Functionality;        
        //private string[] Name;

        //private string[] Parked_Vehicles;
        //private string[] Unparked_Vehicles;
        //private int Currently_Parked;
        //private int Number_of_wheels;
        //private int Number_of_Parking_Space;



        //public Garage()
        //{
        //    Type_Of_Vehical[0] = "Car";           
        //    Type_Of_Vehical[1] = "Caravan";
        //    Type_Of_Vehical[2] = "Bus";
        //    Type_Of_Vehical[3] = "Boat";
        //    Type_Of_Vehical[4] = "Motorcycle";
        //    Type_Of_Vehical[5] = "Airplane";



        //Functionality = new string[6];
        //    Functionality[0] = "Parked_Vehicles";
        //    Functionality[1] = "Name";
        //    Functionality[2] = "Unparked_Vehicles";
        //    Functionality[3] = "Currently_Parked";
        //    Functionality[4] = "Number_of_wheels";
        //    Functionality[5] = "Number_of_Parking_Space";

        //}

        //public void GarageType_Of_Vehical()
        //{
        //    for (int i = 0; i < 5; i++) ;
        //    Console.WriteLine("Type_Of_Vehical in garage:");
        //    Console.ReadLine();
        //}


    

    

