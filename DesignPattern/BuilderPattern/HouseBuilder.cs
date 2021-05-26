using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class IHouseBuilder
    {
        public IHouse _house;

        public IHouseBuilder(IHouse houseobj)
        {
            _house = houseobj;
        }

        public abstract IHouseBuilder BuildBasement();
        public abstract IHouseBuilder BuildStructure();
        public abstract IHouseBuilder BuildWalls();

    }
    class HouseBuilder : IHouseBuilder
    {
        public HouseBuilder(IHouse houseobj) : base(houseobj)
        {
        }

        public override IHouseBuilder BuildBasement()
        {
            _house.SetBasements();
            return this;
        }

        public override IHouseBuilder BuildStructure()
        {
            _house.SetStructure();
            return this;
        }

        public override IHouseBuilder BuildWalls()
        {
            _house.SetWalls();
            return this;
        }
    }
}
