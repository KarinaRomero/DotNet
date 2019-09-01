namespace CoreSchool.Entities
{
    class School
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int YearEstablish { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        /* public School(string name, int yearEstablish)
        {
            this.name = name;
            this.YearEstablish = yearEstablish;
        }
        */
        public School(string name, int yearEstablish) => (Name, YearEstablish) = (name, yearEstablish);

    }
}

