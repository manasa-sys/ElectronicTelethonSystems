using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Project
{

    class donors : CollectionBase
    {
        public void add(Donor donor)
        {
            List.Add(donor);
        }
        public Donor this[int index]
        {
            get { return (Donor)List[index]; }
            set { List[index] = value; }

        }
    }
}
