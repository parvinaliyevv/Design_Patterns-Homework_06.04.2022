using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Computer
    {
        public string License { get; set; }


        // Bad Practice

        //public Windows System { get; set; }
        //public void SetSystem(Windows system) => System = system;


        // Good Practice
        public OperationSystem System { get; set; }
        public void SetSystem(OperationSystem system) => System = system;
    }

    public abstract class OperationSystem
    {
        public string Username { get; set; }
    }

    public class Windows : OperationSystem
    {
        public override string ToString() => nameof(Windows);
    }

    public class KaliLinux : OperationSystem
    {
        public override string ToString() => nameof(KaliLinux);
    }
}
