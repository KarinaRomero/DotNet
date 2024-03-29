
using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class School
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int YearEstablish { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolType Type { get; set; }
        public List<Course> Courses { get; set; }

        public School(string name, int yearEstablish) => (Name, YearEstablish) = (name, yearEstablish);
        public School(string name, int yearEstablish, SchoolType type, string country = "Default value", string city = "Default value")
        {
            (Name, YearEstablish) = (name, yearEstablish);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Name: \"{Name}\", Type: {Type}\nCountry: {Country}, City: {City}{System.Environment.NewLine}YearEstablish: {YearEstablish}";
        }
    }
}

