using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityLib.Models
{
  public  interface IUnivers
    {
        void Add(Student student);

        void Add(Teacher teacher);
        void Add(Facultet facultet);

        void Add(Kafedra kafedra);
        void AddRange(IEnumerable<Student> students);
       
        void AddRange(IEnumerable<Teacher> teachers);

        bool Remove(Student student);
        bool Remove(Teacher teacher) ;

        bool Remove(Kafedra kafedra);

        bool Remove(Facultet facultet);
           

        
        void Update(Student student);
        void Update(Teacher teacher);

        void Update(Facultet facultet);
        void Update(Kafedra ka);


    }
}
