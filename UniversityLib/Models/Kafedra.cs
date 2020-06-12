using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityLib.Models
{
   public class Kafedra
    {
        public string Name { get; set; }
        public Facultet Facultet { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
