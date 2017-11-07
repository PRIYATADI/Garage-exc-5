using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        Garage<T> garage = new Garage<T>(); 
            //[20000]
    }
}
