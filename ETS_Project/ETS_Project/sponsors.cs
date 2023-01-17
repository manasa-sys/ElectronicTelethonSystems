using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Project
{
    class sponsors:CollectionBase
    {
        public void add(sponsor spon)
        {
            List.Add(spon);
        }
        public sponsor this[int index]
        {
            get { return (sponsor)List[index]; }
            set {List[index] = value;}

        }
    }
}
