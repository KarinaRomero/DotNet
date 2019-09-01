using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueID { get; private set; }
        public string Name { get; set; }
        public ScheduleType Schedule { get; set; }

        public Course()=> UniqueID = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"Name: \"{Name}\", ID: {UniqueID}\nSchedule: {Schedule}";
        }
    }
}