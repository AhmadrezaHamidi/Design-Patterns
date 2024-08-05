using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedBuilder.Domian
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }

        private User(UserBuilder builder)
        {
            FirstName = builder.FirstName;
            LastName = builder.LastName;
            Email = builder.Email;
            Address = builder.Address;
        }

        public class UserBuilder
        {
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public string Email { get; private set; }
            public Address Address { get; private set; }

            public UserBuilder SetFirstName(string firstName)
            {
                FirstName = firstName;
                return this;
            }

            public UserBuilder SetLastName(string lastName)
            {
                LastName = lastName;
                return this;
            }

            public UserBuilder SetEmail(string email)
            {
                Email = email;
                return this;
            }

            public UserBuilder SetAddress(Address address)
            {
                Address = address;
                return this;
            }

            public User Build()
            {
                return new User(this);
            }
        }
    }

    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }

        private Address(AddressBuilder builder)
        {
            Street = builder.Street;
            City = builder.City;
        }

        public class AddressBuilder
        {
            public string Street { get; private set; }
            public string City { get; private set; }

            public AddressBuilder SetStreet(string street)
            {
                Street = street;
                return this;
            }

            public AddressBuilder SetCity(string city)
            {
                City = city;
                return this;
            }

            public Address Build()
            {
                return new Address(this);
            }
        }
    }

}
