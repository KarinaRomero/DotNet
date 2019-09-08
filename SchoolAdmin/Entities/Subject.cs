using System;

namespace CoreSchool.Entities
{
    public class Subject
    {
        public string UniqueID { get; private set; }
        public string Name { get; set; }
        public Subject(string name) => (UniqueID, Name) = (Guid.NewGuid().ToString(), name);
        
        public override string ToString()
        {
            return $"Name: \"{Name}\"";
        }
    }
}