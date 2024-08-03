using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoran.Domian
{
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public abstract void Display(int depth = 0);
        public abstract decimal GetTotalPrice();
    }

    public class Dish : MenuItem
    {
        public Dish(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}{Name} - ${Price}");
        }

        public override decimal GetTotalPrice()
        {
            return Price;
        }
    }

    public class Menu : MenuItem
    {
        private List<MenuItem> _items = new List<MenuItem>();

        public Menu(string name)
        {
            Name = name;
            Price = 0; // Menu's price is the sum of its items
        }

        public void Add(MenuItem item)
        {
            _items.Add(item);
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}{Name}");
            foreach (var item in _items)
            {
                item.Display(depth + 1);
            }
        }
        public override decimal GetTotalPrice()
        {
            return _items.Sum(item => item.GetTotalPrice());
        }
    }



}
