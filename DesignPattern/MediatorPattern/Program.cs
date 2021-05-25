using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEventAggregator eventAggregator = new EventAggregrator();
            ModuleA A = new ModuleA(eventAggregator);
            ModuleB B = new ModuleB(eventAggregator);
            ModuleC C = new ModuleC(eventAggregator);

            A.Name = "Apoorva";
            B.Name = "TestString";
            C.Name = "Apoorva Raju";

        }
    }
}
