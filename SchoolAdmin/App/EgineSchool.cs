using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using System.Linq;

namespace CoreSchool
{
    public class EngineSchool
    {
        public School School { get; set; }

        public EngineSchool()
        {

        }

        public void Init()
        {
            // Creating new school
            this.School = new School("HowartsTWO", 1983, SchoolType.Secundaria, city: "Scotland");

            AddCourses();
            AddSubjects();
            AddPerformance();
        }
        private void AddCourses()
        {
            // Adding courses to school
            this.School.Courses = new List<Course>(){
                    new Course(){Name = "Primaria", Schedule = ScheduleType.Night},
                    new Course(){Name = "Secundaria", Schedule = ScheduleType.Evening},
                    new Course(){Name = "Preparatoria", Schedule = ScheduleType.Morning}
            };
            // Adding students to each course
            foreach (var couse in this.School.Courses)
            {
                int randomNumber = new Random().Next(5, 20);
                couse.Students = GetStudents(randomNumber);
                Console.WriteLine(randomNumber);
            }
        }
        private List<Student> GetStudents(int mont)
        {
            string[] names = { "Beta", "Test", "Joan", "Mart", "Citl", "Ger" };
            string[] lastNames = { "Reta", "Lest", "Poan", "Wart", "Kitl", "Fer" };
            string[] names2 = { "Meta", "Yest", "Loan", "Jart", "Xitl", "Per" };
            // Cartesian product
            var students = from name in names
                           from name2 in names2
                           from lastName in lastNames
                           select new Student { Name = $"{name} {name2} {lastName}" };
            return students.OrderBy((st) => st.UniqueID).Take(mont).ToList();
        }
        private void AddSubjects()
        {
            foreach (var course in this.School.Courses)
            {
                List<Subject> subjects = new List<Subject>(){
                    new Subject("Math"),
                    new Subject("Geography"),
                    new Subject("Physics")
                };
                course.Subjects = subjects;
            }
        }
        private void AddPerformance()
        {
            // Contains a global school performance 
            List<Performance> globalPerformance = new List<Performance>();
            // Creating a performance by each course
            foreach (var course in this.School.Courses)
            {
                // Adding a performance by course
                globalPerformance.AddRange(GetPerformanceByCourse(course));
            }
        }
        private List<Performance> GetPerformanceByCourse(Course course)
        {
            // Lis to save a performance 
            List<Performance> performance = new List<Performance>();
            // Contains the name
            string[] names = { "Aprobado", "Reprobado" };
            // Getting each student
            foreach (var student in course.Students)
            {
                // Getting each Subject
                foreach (var subject in course.Subjects)
                {
                    // Getting each Performance
                    for (int i = 0; i < 5; i++)
                    {
                        // Generate a random result
                        var numberRand = new Random();
                        var randomResult = (numberRand.NextDouble()*5);
                        // Deciding whether it is approved or failed
                        string name = (randomResult <= 3) ? names[0] : names[1];
                        // Adding the Performance generated
                        performance.Add(new Performance(name, i + 1, student, subject, (float)randomResult));

                    }
                }
            }
            // Return the list
            return performance;
        }
    }
}