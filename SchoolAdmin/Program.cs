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
            school.Type = TypeSchool.Preescolar;

            var school1 = new School("HowartsTWO", 1983, TypeSchool.Secundaria, city:"Scotland");

            Console.WriteLine(school.ToString());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(school1.ToString());
        }
    }
}
