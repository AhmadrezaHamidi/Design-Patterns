// See https://aka.ms/new-console-template for more information


using System.Xml;
using CompositeSpecificationFirstAdvanced.Structer;





var myMovies = new EvenNumber().And(new PositiveNumber());
Console.WriteLine(  myMovies.IsSatisfiedBy(10));
