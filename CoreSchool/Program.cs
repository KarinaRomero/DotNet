using System;

namespace CoreSchool
{
    class School
    {
        public string name;
        public string adress;
        public int yearEstablish;
        public string ceoName;

        public void Stamp()
        {
            //Todo 
            Console.Beep(30000, 3);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();
            school.name = "MySchoolName";
            school.adress = "number 4, Privet Drive";
            school.yearEstablish = 1981;

            Console.WriteLine(school.name + "Is Dinging");
            school.Stamp();
        }
    }
}
