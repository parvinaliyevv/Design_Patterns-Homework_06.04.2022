using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public static class TypeService
    {
        /// <summary>
        /// The method finds all derived classes
        /// </summary>
        /// <param name="fullname"> This parameter is the fully qualified name of the base type </param>
        /// <returns> List of derived classes </returns>
        public static List<Type> GetDerivedTypes(string fullname)
        {
            var types = new List<Type>();
            
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
                if (item.BaseType?.FullName == fullname) types.Add(item);

            return types;
        }
    }


    public abstract class Fruit
    {
        public int Price { get; set; }
        public bool IsNew { get; set; }
    }

    public class Apple: Fruit { }

    public class Banana: Fruit { }

    public class Orange: Fruit { }
}
