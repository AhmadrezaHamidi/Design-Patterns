using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow.Entities
{
    public enum CoffeeType { Espresso, Latte, Cappuccino, Americano }
    public enum Size { Small, Medium, Large }
    public enum MilkType { Regular, LowFat, Soy, Almond }
  
    public class Coffee
    {
        public CoffeeType Type { get; set; }
        public Size Size { get; set; }
        public MilkType Milk { get; set; }
     

        public override string ToString()
        {
            return $"{Size} {Type} with {Milk} milk, sweetener,";
        }
    }
    public static class CoffeeFactory
    {
        public static CoffeeBuilder CreateCoffe()
        {
            return new CoffeeBuilder();
        }
    }

    public interface ICoffeeBuilder
    {
        ICoffeeTypeBuilder OfType(CoffeeType CoffeeType);
    }
    public interface ICoffeeTypeBuilder
    {
        ISizeBuilder size(Size size);
    }
    public interface ISizeBuilder
    {
        IWithMilk withMilk(CoffeeType milkType);
    }
    public interface IWithMilk
    {
        Coffee Build();
    }
    public class CoffeeBuilder : ICoffeeBuilder, ISizeBuilder, ICoffeeTypeBuilder, IWithMilk
    {
        private Coffee _coffe = new Coffee();
        public Coffee Build()
        {
            return _coffe;
        }

        public ICoffeeTypeBuilder OfType(CoffeeType CoffeeType)
        {
            _coffe.Type = CoffeeType;
            return this;
        }

        public ISizeBuilder size(Size size)
        {
            _coffe.Size = size;
            return this;
        }

        public IWithMilk withMilk(CoffeeType milkType)
        {
            _coffe.Type = milkType;
            return this;
        }

        public IWithMilk withMilk(MilkType milkType)
        {
            _coffe.Milk = milkType;
            return this;
        }
    }
    //var coffee = CoffeeFactory.CreateCoffee()
    //      .OfType(CoffeeType.Latte)
    //      .WithSize(Size.Medium)
    //      .WithMilk(MilkType.Soy)
    //      .Build();
}
