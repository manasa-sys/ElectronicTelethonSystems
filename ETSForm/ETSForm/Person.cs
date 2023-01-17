using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Project
{
    abstract class Person
    {
        string firstname;
        string lastname;

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public virtual string toString()
        {
            return "firstname:"+this.firstname + " " + "lastname:"+this.lastname;
        }
    }
}
