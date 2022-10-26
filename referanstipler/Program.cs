using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referanstipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int s1 = 10;
            //int s2 = 20;
            //s1 = s2;
            //s2 = 100;
            //Console.WriteLine("s1" +s1);

            ////arrays,class,interface... refrence type
            //int[] sayı1 = new int[] { 1, 2, 3, 4, 5, 6, };
            //int[] sayi2 = new int[] { 10, 20, 30, };

            //sayı1 = sayi2;
            //sayi2[0] = 1000;

            //Console.WriteLine("sayılar1[0] =" + sayı1[0] );

           Person person1 = new Person();
           Person person2 = new Person();
            person1.FirstName = "sadık";
            person2 = person1;
            person1.FirstName = "derin";
            Console.WriteLine(person2.FirstName);

           Customer customer = new Customer();
            customer.FirstName = "salih";
            Employee employee = new Employee();
            employee.FirstName = "sds";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    } 
}
