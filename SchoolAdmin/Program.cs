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
            school.Type = SchoolType.Preescolar;

            var school1 = new School("HowartsTWO", 1983, SchoolType.Secundaria, city:"Scotland");

            var courses = new Course[3];

            courses[0] = new Course(){
                Name = "Languaje"
            };
            
            courses[1] = new Course(){
                Name = "Math"
            };

            courses[2] = new Course(){
                Name = "History"
            };

            
            Console.WriteLine("----------------------School------------------");
            Console.WriteLine(school.ToString());
            Console.WriteLine("----------------------School------------------");
            Console.WriteLine(school1.ToString());
            Console.WriteLine("");

            PrintCourse(courses);
            
        }
        private static void PrintCourse(Course[] arrayCourses)
        {
            int counter = 0;

            while(counter < arrayCourses.Length)
            {
                Console.WriteLine(arrayCourses[counter].ToString());
                counter ++;
            }
        }
    }
}
