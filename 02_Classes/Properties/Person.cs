using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        // auto implemented property
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // calculated property
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
