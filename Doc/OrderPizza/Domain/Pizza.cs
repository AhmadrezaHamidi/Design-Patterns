using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza.Domain
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Pizza with {Dough} dough, {Sauce} sauce, {Cheese} cheese, and toppings: {string.Join(", ", Toppings)}";
        }
    }
    public interface IPizzaBuilder
    {
        void SetDough();
        void SetSauce();
        void SetCheese();
        void AddTopping(string topping);
        Pizza Build();
    }



    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void SetDough()
        {
            _pizza.Dough = "thin crust";
        }

        public void SetSauce()
        {
            _pizza.Sauce = "tomato";
        }

        public void SetCheese()
        {
            _pizza.Cheese = "mozzarella";
        }

        public void AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void SetDough()
        {
            _pizza.Dough = "thick crust";
        }

        public void SetSauce()
        {
            _pizza.Sauce = "tomato";
        }

        public void SetCheese()
        {
            _pizza.Cheese = "mozzarella";
        }

        public void AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }

    public class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public Pizza MakePizza(List<string> toppings)
        {
            _builder.SetDough();
            _builder.SetSauce();
            _builder.SetCheese();
            foreach (var topping in toppings)
            {
                _builder.AddTopping(topping);
            }
            return _builder.Build();
        }
    }

}
