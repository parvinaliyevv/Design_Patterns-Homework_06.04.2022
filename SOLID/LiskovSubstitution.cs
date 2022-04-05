using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// this abstract class replaces classes derived from it
    /// </summary>
    public abstract class Transport
    {
        public double Engine { get; set; } // Amazing properties
        public int HorsePower { get; set; }

        /// <summary>
        /// The method returns the class name with path
        /// </summary>
        /// <returns>Fullname class</returns>
        public abstract string GetClassFullname(); 
    }

    /// <summary>
    /// Class inherited from Transport
    /// </summary>
    public class Car : Transport
    {
        public override string GetClassFullname() => typeof(Car).FullName;
    }

    /// <summary>
    /// Class inherited from Transport
    /// </summary>
    public class Motorcycle : Transport
    {
        public override string GetClassFullname() => typeof(Motorcycle).FullName;
    }
}
