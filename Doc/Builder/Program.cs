// See https://aka.ms/new-console-template for more information
using Builder.Domain;

Console.WriteLine("Hello, World!");


        var woodenBuilder = new WoodenHouseBuilder();
        var engineer = new ConstructionEngineer(woodenBuilder);
        var woodenHouse = engineer.ConstructHouse();
        Console.WriteLine(woodenHouse);

        var brickBuilder = new BrickHouseBuilder();
        engineer = new ConstructionEngineer(brickBuilder);
        var brickHouse = engineer.ConstructHouse();
        Console.WriteLine(brickHouse);
