using System;

namespace CoreSchool.Entities
{
    public class Performance
    {
        public string UniqueID { get; private set; }
        public string Name { get; set; }
        public int Lapse { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public float Result { get; set; }
        public Performance(string name, int lapse, Student student, Subject subject, float result) =>
        (UniqueID, Name, Lapse, Student, Subject, Result) = 
        (Guid.NewGuid().ToString(), name, lapse, student, subject, result);

         public override string ToString()
        {
            return $"Name: \"{Name}\", Lapse: {Lapse}\nStudent: {Student.ToString()}, Subject: {Subject.ToString()}\nResult: {Result}";
        }
    }
}