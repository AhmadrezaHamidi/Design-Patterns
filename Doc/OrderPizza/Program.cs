using OrderPizza.Domain;

var margheritaBuilder = new MargheritaPizzaBuilder();
var director = new PizzaDirector(margheritaBuilder);
var margherita = director.MakePizza(new List<string> { "basil" });
Console.WriteLine(margherita);

var pepperoniBuilder = new PepperoniPizzaBuilder();
director = new PizzaDirector(pepperoniBuilder);
var pepperoni = director.MakePizza(new List<string> { "pepperoni", "olives" });
Console.WriteLine(pepperoni);