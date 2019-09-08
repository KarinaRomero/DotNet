using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using static System.Console;
using CoreSchool.Util;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {

            EngineSchool engine = new EngineSchool();
            engine.Init();
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                var numberRand = new Random();
                var randomResult = (numberRand.NextDouble()*5);
                WriteLine(randomResult);
            }
            //PrintCourse(engine.School);

        }
        ///<Sumary>
        private static bool DeleteCourse(Course course)
        {
            return course.Name == "Athletics";
        }
        private static void PrintCourse(School school)
        {

            // if (school != null && school.Courses != null)
            if (school?.Courses != null)
            {
                WriteLine("\n");
                foreach (var course in school.Courses)
                {

                    Printer.PrintLine();
                    Printer.PrintTitle("Course");
                    Printer.PrintLine();
                    WriteLine(course.ToString());
                }
            }

        }
    }
}
