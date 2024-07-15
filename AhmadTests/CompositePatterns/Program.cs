// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using CompositePatterns.FileMangment;

Console.WriteLine("Hello, World!");


var testProject = new TestProj();
Console.WriteLine(testProject.GetSizes());
