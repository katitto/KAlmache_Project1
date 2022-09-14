using System;

namespace KAlmache_Project1
{
    public abstract class Employee : IEmployee
    {
        //We create a abstract class that implements Interface
        //declare atributes
        private string firstName;
        private string lastName;
        private int age;
        private string city;

        //Constructor with parameter
        public Employee(string firstName, string lastName, int age, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
        }
        //Empty Constructor
        public Employee() { }

        //encapsulation principles, get and set
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string City { get => city; set => city = value; }

        public override string? ToString()
        {
            return $"Fist name: {firstName}, Last Name: {lastName}, Age: {age}, City: {city}";
        }



        //interface method for assigActivity
        public void AssigActivity()
        {

            



            throw new NotImplementedException();
        }
    }
}