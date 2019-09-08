using System;

namespace CoreSchool.Entities
{
    public class Student
    {
        public string UniqueID { get; private set; }
        public string Name { get; set; }
        public Student() => UniqueID = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"Name: \"{Name}\"";
        }
    }
}