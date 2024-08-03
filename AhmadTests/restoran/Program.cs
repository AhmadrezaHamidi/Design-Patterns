// See https://aka.ms/new-console-template for more information
using restoran.Domian;

var mainMenu = new Menu("Main Menu");
var appetizerMenu = new Menu("Appetizers");
var mainCourseMenu = new Menu("Main Courses");

appetizerMenu.Add(new Dish("Salad", 5.99m));
appetizerMenu.Add(new Dish("Soup", 4.99m));

mainCourseMenu.Add(new Dish("Steak", 15.99m));
mainCourseMenu.Add(new Dish("Fish", 13.99m));

mainMenu.Add(appetizerMenu);
mainMenu.Add(mainCourseMenu);

mainMenu.Display();
Console.WriteLine($"Total Price: ${mainMenu.GetTotalPrice()}");