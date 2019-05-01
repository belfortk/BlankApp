using System;
namespace HelloWorld
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        private DateTime Birthdate { get; set; }


         public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }


        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }

    }
}
