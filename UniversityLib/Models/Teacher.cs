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
                    Subjects = new List<string>();
                    Subjects.Add(subject);                
            }
            else
            {
                throw new NullReferenceException("subject is null");
            }
        }

        public Teacher(string name ,string surname  , int age,IEnumerable<string> subjects):base(name, surname, age)
        {
            if (subjects != null)
            { 
                    Subjects = new List<string>();
                Subjects.AddRange(subjects);
                
            }
            else
            {
                throw new NullReferenceException("subjects is null");
            }
        }



        public void AddSubject(string subject)
        {
            Subjects.Add(subject);
        }
        public void AddSubjects(IEnumerable<string> subjects)
        {
            Subjects.AddRange(subjects);
        }
    }
}
