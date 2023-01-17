using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Project
{
     class sponsor:Person
    {
        string sponsorID;
        double totalPriceValue;
        public sponsor(string firstname,string lastname,string sponsorID, double totalPriceValue):base(firstname,lastname)
        {
            this.sponsorID = sponsorID;
            this.totalPriceValue = 0;
        }
        public string SponsorID
        {
            get { return this.sponsorID; }
            set { this.sponsorID = value; }
        }
        public double TotalPriceValue
        {
            get { return this.totalPriceValue; }
            set { this.totalPriceValue = value; }
        }
        public string getID()
        {
            return this.sponsorID;
        }
        public override string toString()
        {
            return base.toString() + " " +"sponsorId:"+this.sponsorID+" "+ "totalValue:"+this.totalPriceValue;
        }
       /* public double  AddValue(double value,int noofprizes)
        {
            return TotalPriceValue = noofprizes * value;
        }*/

        public void calculateTotalValue(double value, int noofitems)
        {
            this.totalPriceValue =(noofitems * value);

        }
    }
}
