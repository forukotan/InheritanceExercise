using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Reptile : Animal
    {
        public Reptile()
        {
           
            hasFur = false;
            hasTail = true;
            
        }

        public bool IsScaly { get; set; }
        public bool ColdBlooded { get; set; }
        public string Diet { get; set; }
        public string Habitat { get; set; }
    }
}
