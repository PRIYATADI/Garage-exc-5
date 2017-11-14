
using GarageProject.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{ /*
     * We implement the IEnumerable<T> in order to be able to use, amoung otherthings,
     * the foreach-loop with instances of the Garage
     */
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        //Console.WriteLine(" Introduce the maximum capacity of the new garage:  ");

        // int Maxcapacity;

        //Console.ReadLine();
        //Garage<T> garage = new Garage<T>();

        //[20000]private T[] vehicleArray;[Maxcapacity]


            //Garage vehicle = new Garage();
   
        private T[] garageArray;
        private int capacity;
        private int count;
        private bool[] isParkingPlaceAvailables;

        /*
        * Both the Capacity and Count properties are made in such a way that the only thing
        *  other classes can do with them is to read the value that their linked field contains
        */      

        public int Capacity { get { return capacity; } }
        public int Count { get { return count; } private set { count = value; } }

      
        public Garage(T input)

        {
            /*
            * We make sure that the garage will only be the founding vehicle
            the type of the in-parameter "input" is of the type Vehicle or a child of it
            * 
            */
            if (typeof(Vehicle).IsAssignableFrom(input.GetType()))
            //{
            //    capacity = ((input as Vehicle).numberOfSeats % 3) + 7;
            //    garageArray = new T[capacity];
            //}
            ///*
            //* otherwise we ensure that in 
            //*/
            //else
            {
                capacity = 1;
                garageArray = new T[1];
            }
            garageArray[0] = input;
            Count = 1;
        }

        /*
       * Since count will always be one highter than the index of the last added
       * garage vehicle, we can use count to add new vehicles to the end of the roster
       */
        //Creating garage with a set capacity 

        public Garage(int maxSetCapacity)
        {
            //Garage nrMaximVehicule = new Garage<T>

            int maxCapacity = UserInterface1.maximumSetCapacity;
          
            //Console.WriteLine(Garage.Array.GetCapacity());
        }
        public Garage()
        {
            bool[] isParkingPlaceAvailable = new bool[MaxCapacity];
            for (int i = 0; i < MaxCapacity; i++)
            {
                isParkingPlaceAvailable[i] = true;
            }

        }

        //public int GarageSize(string vehType)
        // {
        //        { if (vehType == "Airplan")
        //            {garageSize=Console.ReadLine() }
        //           elseif (vehType == "Boat"
        //                { garageSize = Console.ReadLine() }
        //           elseif(vehType == "Bus"
        //                { garageSize = Console.ReadLine() }
        //            elseif(vehType == "Cars"
        //                { garageSize = Console.ReadLine() }
        //            elseif(vehType == "Helicopter"
        //                { garageSize = Console.ReadLine() }
        //            elseif(vehType == "Moped"
        //                { garageSize = Console.ReadLine() }
        //            elseif(vehType == "Motorcycle"
        //                { garageSize = Console.ReadLine() }
        //            elseif(vehType == "Van"
        //                { garageSize = Console.ReadLine() }
        //            else
        //         {
        //                ;      
        //            }
        //        }
        //}
        /*
        *Since count will always be one higher than the index of the last vehicle added in the garage, 
        *we can use count to add new mwmbers to the end of the roster
        */
        public void Park(T input)
        {
            if (count < capacity)
            {
                garageArray[count++] = input;
            }
          }
        /*
        * The public void Unpark method ensures that the array is kept ordered with all the nulls
        * at the bottom, it does this by constantly moving all members after the one
        * being removed up one step and the finaly setting the last doublett to null.
        */
        public void Unpark(int id)
        {
            if (id != 0 && id <= capacity && garageArray[id] != null)
            {
                //garageArray[id] = null;
                if (id + 1 != capacity)
                {
                    /*
                     * mistake and overly convoluted
                     */
                    //for(int i = 1; i <garageArray.ToList().IndexOf(null);i++)
                    //{

                    //}
                    for (int i = id; i < capacity; i++)
                    {
                        if (garageArray[i + 1] != null && i + 1 != capacity)
                        {
                            garageArray[i] = garageArray[i + 1];
                        }
                        else
                        {
                            garageArray[i] = null;
                        }
                    }
                }
                else
                {
                    garageArray[id] = null;
                }
                count--;
            }
        }
        /*
         * These functions are what lets us implement the IEnumerable interface
         * The yield return lets the function return multiple times without having to call 
         * the function again and again.
         */
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return garageArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
            {
                //Vehicle printList = new Vehicle();
                //printList.PrintParkedVehicle(Vehicle veh);
            }

            //Vehicle vehicle = new Vehicle();
            //List<Vehicle> vehicleList = new List<Vehicle>();
            //vehicleList.Add(vehicle.CreateParkedVehicle)

           
            //foreach (Vehicle v in vehicleList)
            //{
            //    Console.WriteLine(vehicle.PrintParkedVehicle(v));
            //}
        
        
        //public class Garage<T> where T : Vehicle
        //{
        //    public int NextId = 0;
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public List<T> Vehicles { get; set; }

        //    private int nextId = 0;

        //    public Garage(string name)
        //    {
        //        this.Id = NextId++;
        //        this.Name = name;
        //        this.Vehicles = new List<T>();
        //    }

        //    public Garage() : this("")
        //    {
        //    }



        //    public override string ToString()
        //    {

        //        return string.Format("{0, 0}{1, 30} {2, 5}", Id, Name, Vehicles.Count);
        //    }

        //}


    }
}   
        
    

