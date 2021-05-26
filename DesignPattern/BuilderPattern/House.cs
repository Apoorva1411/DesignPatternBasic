using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IHouse
    {
        
        void SetBasements();
        void SetStructure();
        void SetWalls();

    }

    public class FabricatedHouse : IHouse
    {
        public void SetBasements()
        {
            Console.WriteLine("Set basement for Fabricated house");
        }

        public void SetStructure()
        {
            Console.WriteLine("Set Structure for Fabricated house");
        }

        public void SetWalls()
        {
            Console.WriteLine("Set Walls for Fabricated house");
        }
    }

    public class Igloo : IHouse
    {
        public void SetBasements()
        {
            Console.WriteLine("Set basement for Igloo house");
        }

        public void SetStructure()
        {
            Console.WriteLine("Set Structure for Igloo house");
        }

        public void SetWalls()
        {
            Console.WriteLine("Set Walls for Igloo house");
        }
    }

    public class RCCHouse : IHouse
    {
        public void SetBasements()
        {
            Console.WriteLine("Set basement for RCCHouse house");
        }

        public void SetStructure()
        {
            Console.WriteLine("Set Structure for RCCHouse house");
        }

        public void SetWalls()
        {
            Console.WriteLine("Set Walls for RCCHouse house");
        }
    }
}
