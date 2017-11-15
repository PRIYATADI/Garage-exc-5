using GarageProject.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
     /*
     * We implement the IEnumerable<T> in order to be able to use, amoung otherthings,
     * the foreach-loop with instances of the Garage
     */
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public Garage()
        {
        }
        //private T[] garageArray;
        //private bool[] isParkingPlaceAvailables;
        //public Garage()
        //{
        //    bool[] isParkingPlaceAvailable = new bool[MaxCapacity];
        //    for (int i = 0; i < MaxCapacity; i++)
        //    {
        //        isParkingPlaceAvailable[i] = true;
        //    }
        //}
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
        //public void Park(T input)
        //{
        //    if (count < capacity)
        //    {
        //        garageArray[count++] = input;
        //    }
        //}
        /*
        * The public void Unpark method ensures that the array is kept ordered with all the nulls
        * at the bottom, it does this by constantly moving all members after the one
        * being removed up one step and the finaly setting the last doublett to null.
        */
        //public void Unpark(int id)
        //{
        //    if (id != 0 && id <= capacity && garageArray[id] != null)
        //    {
        //        //garageArray[id] = null;
        //        if (id + 1 != capacity)
        //        {
        //            /*
        //             * mistake and overly convoluted
        //             */
        //            //for(int i = 1; i <garageArray.ToList().IndexOf(null);i++)
        //            //{
        //            //}
        //            for (int i = id; i < capacity; i++)
        //            {
        //                if (garageArray[i + 1] != null && i + 1 != capacity)
        //                {
        //                    garageArray[i] = garageArray[i + 1];
        //                }
        //                else
        //                {
        //                    garageArray[i] = null;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            garageArray[id] = null;
        //        }
        //        count--;
        //    }
        //}
        // * These functions are what lets us implement the IEnumerable interface
        // * The yield return lets the function return multiple times without having to call 
        // * the function again and again.
        // */
        //Vehicle printList = new Vehicle();
        //printList.PrintParkedVehicle(Vehicle veh);
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
    
        private List<T> nrVehicles;
        private int maxCapacity;
        private int count;
        private string garageName;
        private string garageAdress;

        public int MaxCapacity { get { return maxCapacity; } }
        public int Count { get { return count; } private set { count = value; } }
        public string GarageName { get { return garageName; } private set { garageName = value; } }
        public string GarageAdress { get { return garageAdress; } private set { garageAdress = value; } }
              
        ////Creating garage with a set capacity introduced by the user1

        //public Garage(int maxSetCapacity)
        //{
        //    nrVehicles = new List<T>();
        //    maxCapacity = sMaximumSetCapacity;
        //    Console.WriteLine("\n *********************************************\n");
        //    Console.WriteLine(" The capacity of the Garage");
           
        //    Console.WriteLine( "Garage has a capacity of: " );
        //    int maxSetCapacity=int.Parse(Console.ReadLine());
        //    //Console.WriteLine(Garage.Array.GetCapacity());
        //}

        //creating the garage with the capacity introduced by the user1
        public Garage(int maximumSetCapacity)
        {
            nrVehicles = new List<T>();
            maxCapacity = maximumSetCapacity;

            Console.WriteLine("\n ***********************************************************\n");
            Console.WriteLine("New Garage is created with a capacity of: " + maximumSetCapacity
                                + "vehicles");
            Console.WriteLine("\n ***********************************************************\n");
            Console.ReadLine();
        }

        //Add vehicles into garage

        public void ParkSpecificVehiclesIntoTheGarage(T input)
        {
            if (maxCapacity - nrVehicles.Count <= 0)
            {

                Console.WriteLine("\n-----------------------------------------------\n  " +
                    "Garage is full, there is no possible to park. Sorry!\n" +
                    "----------------------------------------------------");
                return;
            }
            if (count < maxCapacity)
            {
                nrVehicles.Add(input);
                count++;
            }
            Console.WriteLine("----------------------------------------\n" +
                "Your vehicle was succesfully parked\n" +
                "----------------------------------------\n");
            Console.WriteLine("-------------------------------------------------\n" +
                "The garage has now :" + (maxCapacity - nrVehicles.Count) +
                " free parking places\n------------------------------------------");
            Console.ReadLine();
        }
        //Remove vehicles from the garage

        public void unparkSpecificVehiclesFromTheGarage(T input)
        {
            string unparkRegistrationNumber = input.RegistrationNumber;
            var match = nrVehicles.Where(stc => stc.RegistrationNumber.Contains(unparkRegistrationNumber));
            if (nrVehicles.Count == 0)
            {
                Console.WriteLine("There are no vehicles parked in the garage!");
                return;
            }

            else if (match != null && match.Any())
            /*(count <= maxCapacity)*/
            {
                string unparkRegistrationNumberl = input.RegistrationNumber;
                nrVehicles.RemoveAll(x => x.RegistrationNumber.StartsWith(unparkRegistrationNumberl));

                Console.WriteLine("------------------------------------------------------\n" +
                    "The vehicle with the Registration Number: " + unparkRegistrationNumber +
                     " was succesfully unparked.\n" +
                    "\n-----------------------------------------------------------------");
                count--;
            }
            else
            {
                Console.WriteLine("----------------------------------------------------------\n" +
                     "The vehicle with the Registration Number: " + unparkRegistrationNumber +
                      " was not found in the garage.\n" +
                      "\n--------------------------------------------------------------------");
            }
            Console.WriteLine("------------------------------------------------------\n" +
                "In the garage there are :" + (maxCapacity - count) + " vehicles now." +
                "\n------------------------------------------------------------------");
            Console.ReadLine();
        }

        // List All Parked Vehicles
        Vehicle TestIfThereAreVehicle = new Vehicle();

        public void ListAllParkedVehicles()
        {
            if (nrVehicles.Count == 0)
            {
                Console.WriteLine("There are no vehicles in the garage.");
            }
            else
            {
                foreach (var veh in nrVehicles)
                {
                    Console.WriteLine(TestIfThereAreVehicle.VehicleInformations());
                }
                Console.WriteLine("The total number of the parked vehicles is :" + nrVehicles.Count.ToString());
            }
            Console.ReadLine();
        }

        //List of the all types of vehicles that are now parked in the garaj:
        public void ListAllVehiclesTypesCurrentlyParkedInTheGarage()
        {
            Console.Clear();
            int airCount = nrVehicles.Where(x => x.Type.Contains("AIRPLANE")).Count();
            Console.WriteLine("There are: " + airCount + "in the garage");

            int boatCount = nrVehicles.Where(x => x.Type.Contains("BOAT")).Count();
            Console.WriteLine("There are: " + boatCount + "in the garage");

            int busCount = nrVehicles.Where(x => x.Type.Contains("BUS")).Count();
            Console.WriteLine("There are: " + busCount + "in the garage");

            int helicopterCount = nrVehicles.Where(x => x.Type.Contains("CAR")).Count();
            Console.WriteLine("There are: " + helicopterCount + "in the garage");

            int motorcycleCount = nrVehicles.Where(x => x.Type.Contains("MOTORCYCLE")).Count();
            Console.WriteLine("There are: " + motorcycleCount + "in the garage");

            int mopedCount = nrVehicles.Where(x => x.Type.Contains("BOAT")).Count();
            Console.WriteLine("There are: " + mopedCount + "in the garage");

            int vanCount = nrVehicles.Where(x => x.Type.Contains("AIRPLANE")).Count();
            Console.WriteLine("There are: " + vanCount + "in the garage");



            Console.WriteLine("-----------------------------------------------\n" +
                "In the garage there are :" + nrVehicles.Count.ToString() +
                "\n-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------------\n" +
            "The capacity of the garage is :" + maxCapacity +
            "\n-----------------------------------------------------");
            Console.ReadLine();
        }

        /*
        *These functions are what lets us implement the IEnumerable interface
        * The yield return lets the function return multiple times without having to call 
        * the function again and again.
        */
        //IEnumerable GetEnumerator methods for looping in the list
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return nrVehicles[i];
            }
        }
        //IEnumerator IEnumerable.GetEnumerator()
        //{

        //    return GetEnumerator();
        //}


        //Search a vehicle in the garage
        //public void SearchAVehicleIntoOrFromTheGarage()
        //{
            public void SearchByModel(T mSearch)
        {
            string searched = mSearch.Model;
            var match = nrVehicles.Where(stc => stc.Model.Contains(searched));
            int count = 0;
            if (nrVehicles.Count == 0)
            {
                Console.WriteLine("There are no vehicles in the garage, so we can not search.");
                Console.ReadLine();
                return;
            }

            if (match != null && match.Any())

            {
                foreach (var veh in match)
                {
                    count++;
                }
                Console.WriteLine("There are " + count + " vehicles that are  " + searched + "model");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There are not vehicles that matches the " + searched + "criteria");
                Console.ReadLine();
            }

        }
        public void SearchByNumberOfWheels(T wSearch)
        {
            int searched = wSearch.NumberOfWheels;
            var match = nrVehicles.Where(stc => stc.NumberOfWheels.Equals(searched));
            int count = 0;
            if (nrVehicles.Count == 0)
            {
                Console.WriteLine("There are no vehicles in the garage, so we can not search.");
                Console.ReadLine();
                return;
            }

            if (match != null && match.Any())

            {
                foreach (var veh in match)
                {
                    count++;
                }
                Console.WriteLine("There are " + count + " vehicles that have  " + searched + "wheels");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There are not vehicles that matches the " + searched + "criteria");
                Console.ReadLine();
            }

        }

        public void SearchBySeatNumber(T seatsSearch)
        {
            int searchedVeh = seatsSearch.NumberOfSeats;
            var match = nrVehicles.Where(stc => stc.NumberOfSeats.Equals(searchedVeh));
            int count = 0;
            if (nrVehicles.Count == 0)
            {
                Console.WriteLine("There are no vehicles in the garage, so we can not search.");
                return;
            }

            if (match != null && match.Any())

            {
                foreach (var veh in match)
                {
                    count++;
                }
                Console.WriteLine("There are " + count + " vehicles that have  " + searchedVeh + "number of seats");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There are not vehicles that matches the " + searchedVeh + "criteria");
                Console.ReadLine();
            }

        }
    }
}
//public IEnumerator<T> GetEnumerator()
//        {
//            for (int i = 0; i < count; i++)
//            {
//                yield return garageArray[i];
//            }
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }