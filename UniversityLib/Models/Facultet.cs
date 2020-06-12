using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityLib.Models
{
   public class Facultet 
    {
        public string Name { get; private set; }
        public List<Kafedra> Kafedras { get; set; }
       

        public Facultet(string name)
        {
            if (name!=null)
            {
                Name = name;
            }
        }

        public Facultet(string name ,Kafedra kafedra)
        {
            if (name!=null&&kafedra!=null)
            {
                Name = name;
                Kafedras.Add(kafedra);
            }

        }
       

       

       

      
       

       

       
    }
}
