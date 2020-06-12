using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityLib.Models
{
  public abstract  class Person
    {
        public  string Name { get; protected set; }
        public  string Surname { get; protected set; }

        public int Age { get; protected set; }

        public Person(string name, string surname, int age)
        {
            if (name != null && surname != null && age >= 16)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }
            else
            {
                throw new Exception("Wrong parameters");
            }
           
        }
    }
}
