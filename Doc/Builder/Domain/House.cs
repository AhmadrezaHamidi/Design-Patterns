using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Domain
{
    // Product
    public class House
    {
        public string Foundation { get; set; }
        public string Structure { get; set; }
        public string Roof { get; set; }

        public override string ToString()
        {
            return $"House with {Foundation} foundation, {Structure} structure, and {Roof} roof";
        }
    }

    // Builder
    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildStructure();
        void BuildRoof();
        House GetResult();
    }

    // ConcreteBuilder for wooden house
    public class WoodenHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildFoundation()
        {
            _house.Foundation = "wooden piles";
        }

        public void BuildStructure()
        {
            _house.Structure = "wooden panels";
        }

        public void BuildRoof()
        {
            _house.Roof = "wooden shingles";
        }

        public House GetResult()
        {
            return _house;
        }
    }

    // ConcreteBuilder for brick house
    public class BrickHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildFoundation()
        {
            _house.Foundation = "concrete";
        }

        public void BuildStructure()
        {
            _house.Structure = "bricks";
        }

        public void BuildRoof()
        {
            _house.Roof = "tiles";
        }

        public House GetResult()
        {
            return _house;
        }
    }

    // Director
    public class ConstructionEngineer
    {
        private IHouseBuilder _houseBuilder;

        public ConstructionEngineer(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public House ConstructHouse()
        {
            _houseBuilder.BuildFoundation();
            _houseBuilder.BuildStructure();
            _houseBuilder.BuildRoof();
            return _houseBuilder.GetResult();
        }
    }

 


}
