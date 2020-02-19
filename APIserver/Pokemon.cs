using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIserver
{
    public class Pokemon
    {
        public string Name {
            get
            {
                return Name;
            }
            set
            {
                Name = value.ToUpper();
            }
        }


        public int Strength { get; set; }

    }
}
