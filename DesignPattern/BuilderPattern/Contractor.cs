using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Contractor
    {
        private IHouse _house;
        private IHouseBuilder _housebuilder;

        public Contractor(IHouse house, IHouseBuilder builder)
        {
            _house = house;
            _housebuilder = builder;
        }
        public void ConstructHouse()
        {
            //Fluent Influence Pattern
            _housebuilder.BuildBasement().BuildStructure().BuildWalls();
        }
    }
}
