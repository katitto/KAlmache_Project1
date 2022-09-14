using System;

namespace KAlmache_Project1
{
    public class Programmer : Employee
    {
        //atributos propios de programador
        private string lenguajeCoding;

        //herencia
        public Programmer(string firstName, string lastName, int age, string city, string lenguajeCoding) : base(firstName, lastName, age, city)
        {
            this.lenguajeCoding = lenguajeCoding;
        }

        public string LenguajeCoding { get => lenguajeCoding; set => lenguajeCoding = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}