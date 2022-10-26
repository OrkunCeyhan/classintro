using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer (  1, "asd","ddd","ad");

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer (2,"d","ddda","add");

            Console.WriteLine(customer.FirstName);
        }
        class Customer
        {
            public Customer()
            {

            }
            public Customer(int id, string firstname, string lastname, string city)
            {
                Id = id;
                FirstName = firstname;
                LastName= lastname;
                City    = city;
            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
