using System;
using CoreSchool.Entities;
using static System.Console;

namespace SchoolAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("HowartsTWO", 1983, SchoolType.Secundaria, city: "Scotland");

            school.Courses = new Course[]{
                    new Course(){Name = "Languaje"},
                    new Course(){Name = "Math"},
                    new Course(){Name = "History"}
            };

            WriteLine("----------------------School------------------");
            WriteLine(school.ToString());

            PrintCourse(school);

        }
        private static void PrintCourse(School school)
        {
            // if (school != null && school.Courses != null)
            if (school?.Courses != null)
            {
                WriteLine("\n");
                foreach (var course in school.Courses)
                {
                    WriteLine("----------------------Course------------------");
                    WriteLine(course.ToString());
                }
            }

        }
    }
}
