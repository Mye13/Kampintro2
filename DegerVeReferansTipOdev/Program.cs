using System;

namespace DegerVeReferansTipOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //değer tipler - value types
            //referans tipler - referance types

            Person person = new Person();
        }
    
    }

    class Person
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee :Person
    {
        public int EmployeeNumber { get; set; }
    }
}
