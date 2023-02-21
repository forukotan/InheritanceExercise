using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal

    {
        public Bird()
        {
            legs = 2;
            hasFur = false;
            hasTail = false;
            teeth = 0;
        }

        public int beakLength { get; set; }
        public bool hasTalons { get; set; }
        public string colorFeathers { get; set; }
        public string diet { get; set; }



    }
}
