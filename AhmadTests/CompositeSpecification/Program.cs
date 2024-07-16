// See https://aka.ms/new-console-template for more information

using CompositeSpecification.Structer;

Console.WriteLine("Hello, World!");

int number = Convert.ToInt32(Console.ReadLine());
// var evenNUmber  = new EvenNumber().IsSatisfiedBy(number);
// var PositeveNmber = new PositiveNumber().IsSatisfiedBy(number);
// var evenAndPositeveNumbver = new AndSpecofocation<bool>( new EvenNumber(),evenNUmber)


    
var evenNUmber  = new EvenNumber();
var Positive = new PositiveNumber();
var evenAndPositeveNumbver = new AndSpecofocation<int>(evenNUmber, Positive);
evenAndPositeveNumbver.IsSatisfiedBy(30);


