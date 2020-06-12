using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityLib.Models
{
   public class Teacher:Person
    {
        public List<string> Subjects { get; private set; }
        public Teacher(string name, string surname, int age):base(name,surname,age)
        {

        }
        public Teacher(string name ,string surname ,int age,string subject): base(name, surname, age)
        {
            if (subject!=null)
            {
                Subjects
            }
            else
            {
                throw new NullReferenceException("subject is null");
            }
        }
    }
}
