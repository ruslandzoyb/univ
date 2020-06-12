using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityLib.Models
{
   public class Student :Person
    {
        private string groupId;
        private Kafedra kafedra;
        private Facultet facultet;
        public string GroupId
        {

            get { return groupId; }
             set
            {
                if (value==null)
                {
                    throw new Exception("Group is null");
                }
                groupId = value;
            } }

      
        public Facultet Facultet
        {
            get => facultet; set
            {
                if (value==null)
                {
                    throw new Exception("Facultet is null");
                }
                facultet = value;
            } }
        public Kafedra Kafedra { get=>kafedra;
            set             
            {
                if (value == null)
                {
                    throw new Exception("Kafedra is null");
                }
                kafedra = value;
            } }

        public Student(string name ,string surname ,int age,string groupId,Facultet facultet,Kafedra kafedra) :base(name,surname,age)
        {
            if (groupId!=null&&facultet!=null&&kafedra!=null)
            {
                GroupId = groupId;
            }
            else
            {
                throw new Exception("Wrong parameters");
            }
        }

        public Student(string name, string surname, int age): base(name,surname,age)
        {

        }
    }
}
