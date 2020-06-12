using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UniversityLib.Models
{
    class UniversityManager  :IUnivers
    {
        public List<Facultet> Facultets { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public void Add(Student student)
        {
            Students.Add(student);
            //var fac = Facultets.Find(x => x.Name == student.Facultet.Name);
            //var kaf = fac.Kafedras.Find(x => x.Name == student.Kafedra.Name);
            //if (fac==null)
            //{
            //    Add(student.Facultet);
            //}
            //if (kaf==null)
            //{
            //    Add(student.Kafedra);
            //}
            //Students.Add(student);

        }

        public void Add(Teacher teacher)
        {           
            
            Teachers.Add(teacher);
        }

        public void Add(Facultet facultet)
        {
            Facultets.Add(facultet);
        }

        public void Add(Kafedra kafedra)
        {
            var fac = Facultets.SingleOrDefault(x=>x.Name==kafedra.Facultet.Name);
            fac.Kafedras.Add(kafedra);

        }

        public void AddRange(IEnumerable<Student> students)
        {
            foreach (var item in students)
            {
                Add(item);
            }
        }

        public void AddRange(IEnumerable<Teacher> teachers)
        {
            foreach (var item in teachers)
            {
                Add(item);
            }
        }

        public bool Remove(Student student)
        {
            var stud = Students.Find(x => x.Name == student.Name && x.Surname == student.Surname && x.Age == student.Age && x.GroupId == student.GroupId);
            if (stud!=null)
            {
                Students.Remove(stud);
                return true;
            }
            return false;
        }

        public bool Remove(Teacher teacher)
        {
            var teach = Teachers.Find(x => x.Name == teacher.Name && x.Surname == teacher.Surname && x.Age == teacher.Age );
            if (teach != null)
            {
                Teachers.Remove(teach);
                return true;
            }
            return false;
        }

        public bool Remove(Kafedra kafedra)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Facultet facultet)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public void Update(Facultet facultet)
        {
            throw new NotImplementedException();
        }

        public void Update(Kafedra ka)
        {
            throw new NotImplementedException();
        }
    }
}
