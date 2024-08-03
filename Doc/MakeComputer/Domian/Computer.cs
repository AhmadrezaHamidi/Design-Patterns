using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MakeComputer.Domian
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }

        public override string ToString()
        {
            return $"Computer Specifications:\n" +
                   $"CPU: {CPU}\n" +
                   $"RAM: {RAM}\n" +
                   $"Storage: {Storage}\n" +
                   $"Graphics Card: {GraphicsCard}";
        }
    }
    public interface IMakeComputer
    {
        void AddCpu(string name);
        void AddRAM(string name);
        void AddStorage(string name);
        void AddGraphicsCard(string name);
        Computer MadeComputer();
    }

    public class MakeAsus : IMakeComputer
    {
        private Computer _pc = new Computer();
        public void AddCpu(string name) => _pc.CPU = name + "Asus";
        public void AddGraphicsCard(string name) => _pc.GraphicsCard = name + "Asus"; 
        public void AddRAM(string name) => _pc.GraphicsCard = name + "Asus";
        public void AddStorage(string name) => _pc.GraphicsCard = name + "Asus";
        public Computer MadeComputer() => _pc;
    }
    public class MakeMackBook : IMakeComputer
    {
        private Computer _pizza = new Computer();
        private Computer _pc = new Computer();
        public void AddCpu(string name) => _pc.CPU = name + "Apple";
        public void AddGraphicsCard(string name) => _pc.GraphicsCard = name +"Apple";
        public void AddRAM(string name) => _pc.GraphicsCard = name + "Apple";
        public void AddStorage(string name) => _pc.GraphicsCard = name + "Apple";
        public Computer MadeComputer() => _pc;
    }

    public class ComputerDirector
    {
        private readonly IMakeComputer _builder;

        public ComputerDirector(IMakeComputer makeComputer)
        {
            this._builder = makeComputer;
        }

        public Computer MakePizza(string name)
        {
            _builder.AddCpu(name);
            _builder.AddRAM(name);
            _builder.AddGraphicsCard(name);
            _builder.AddStorage(name);
            return _builder.MadeComputer();
        }
    }




}
