using System;
using CoreSchool.Entities;

namespace SchoolAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Howarts", 1983);
            school.Country = "Scotland";
            school.City = "Edinburgh";
            Console.WriteLine("My school is " + school.Name);
        }
    }
}
