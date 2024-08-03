// See https://aka.ms/new-console-template for more information
using MakeComputer.Domian;

Console.WriteLine("Hello, World!");



var margheritaBuilder = new MakeMackBook();
var director = new ComputerDirector(margheritaBuilder);
var margherita = director.MakePizza("Ahmad");
Console.WriteLine(margherita.CPU);

var pepperoniBuilder = new MakeAsus();
director = new ComputerDirector(pepperoniBuilder);
var pepperoni = director.MakePizza("Sohi");
Console.WriteLine(pepperoni.CPU);