
//using GarageProject.Vehicle;
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


        private T[] garageArray;
        private int capacity;
        private int count;

        /*
        * Both the Capacity and Count properties are made in such a way that the only
        * thing other classes can do with them is to read the value that their linked feild
        * contains
        */

        public int Capacity { get { return capacity; } }
        public int Count { get { return count; } private set { count = value; } }


        public Garage(int capacity)

        {
            /*
            * We make sure that the type of the in parameter "input" is of the type Vehicle/Car
            * or a child of it
              */

            garageArray = new T[capacity];

            /*
            * otherwise we ensure that in the garage will only be the founding vehicle
            */

        }
    

        /*
        * Since count will always be one highter than the index of the last added
        * garage vehicle, we can use count to add new vehicles to the end of the roster
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

    }
}



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

