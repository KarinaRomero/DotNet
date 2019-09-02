using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using static System.Console;

namespace SchoolAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating new school
            var school = new School("HowartsTWO", 1983, SchoolType.Secundaria, city: "Scotland");
            // Adding courses to school
            school.Courses = new List<Course>(){
                    new Course(){Name = "Languaje", Schedule = ScheduleType.Night},
                    new Course(){Name = "Math", Schedule = ScheduleType.Night},
                    new Course(){Name = "History", Schedule = ScheduleType.Morning}
            };
            // Adding one course more
            school.Courses.Add(new Course(){Name = "Geography", Schedule = ScheduleType.Night});
            // Deleting 
            //school.Courses.Clear();
            // Creating range courses
            var otherCourses = new List<Course>(){
                    new Course(){Name = "Chemistry"},
                    new Course(){Name = "Physics"},
                    new Course(){Name = "Athletics"}
            };
            // Adding range courses
            school.Courses.AddRange(otherCourses);
            // Creating temporal course
            var temporalCourse = new Course{Name = "Artificial intelligence", Schedule = ScheduleType.Night};
            // Adding one course more
            school.Courses.Add(temporalCourse);
            // Deleting one course by object
            school.Courses.Remove(temporalCourse);
            // Deleting one course by Predicate
            school.Courses.RemoveAll(DeleteCourse);
            // Deleting one course by Predicate exponig the logic delegate    
            Predicate<Course> deleteLogic = DeleteCourse;
            school.Courses.RemoveAll(deleteLogic);
            // Deleting by lambda expressions
            school.Courses.RemoveAll(delegate(Course cur) {return cur.Name == "Physics";});
            school.Courses.RemoveAll((Course cur) => cur.Schedule == ScheduleType.Morning);


            WriteLine("----------------------School------------------");
            WriteLine(school.ToString());
            // Printing all courses
            PrintCourse(school);

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
                    WriteLine("----------------------Course------------------");
                    WriteLine(course.ToString());
                }
            }

        }
    }
}
