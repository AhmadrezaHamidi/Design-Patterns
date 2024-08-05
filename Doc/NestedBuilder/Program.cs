// See https://aka.ms/new-console-template for more information
using NestedBuilder.Domian;

Console.WriteLine("Hello, World!");
        var address = new Address.AddressBuilder()
                                .SetStreet("123 Main St")
                                .SetCity("Tehran")
                                .Build();

        var user = new User.UserBuilder()
                           .SetFirstName("Saghar")
                           .SetLastName("Tabatabaei")
                           .SetEmail("saghar@example.com")
                           .SetAddress(address)
                           .Build();

        Console.WriteLine($"User: {user.FirstName} {user.LastName}, Email: {user.Email}, Address: {user.Address.Street}, {user.Address.City}");
