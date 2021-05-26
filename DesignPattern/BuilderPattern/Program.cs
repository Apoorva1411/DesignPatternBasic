using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHouse Igloohouse = new RCCHouse();
            IHouseBuilder builder = new HouseBuilder(Igloohouse);
            Contractor contract = new Contractor(Igloohouse,builder);
            contract.ConstructHouse();

        }
    }
}
