using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Project
{
    class Prize
    {
        string prizeID;
        string description;
        double value;
        int originalAvailable;
        double donationLimit;
        int currentAvailable;
        string sponsorID;

        public Prize(string prizeID, string description, double value, double donationLimit, int originalAvailable , string sponsorID)
        {
            this.prizeID = prizeID;
            this.description = description;
            this.value = value;
            this.donationLimit = donationLimit;
            this.originalAvailable=originalAvailable;
            this.currentAvailable = originalAvailable;
            this.sponsorID = sponsorID;
        }
        public string PrizeID
        {
            get { return this.prizeID; }
            set { this.prizeID = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public double DonationLimit
        {
            get { return this.donationLimit; }
            set {
                this.donationLimit = value;
            }
        }
        public int OriginalAvailable
        {
            get { return this.originalAvailable; }
            set
            {
                this.originalAvailable = value;
            }
        }
        public int Currentavailable
        {
            get { return this.currentAvailable; }
            set
            {
                this.currentAvailable = value;
            }
        }
        public string SponsorID
        {
            get { return this.sponsorID; }
            set { 
                this.sponsorID = value;
            }
        }
        public string toString()
        {
            return "prizeID:"+this.prizeID + " " +"description:"+ this.Description + "value:"+" "+this.value+" "+ "donationlimit:"+this.donationLimit + " "+"originalavailable:"+this.originalAvailable+" " +
                 " "+"current available:"+this.currentAvailable+"sponsorid:"+this.sponsorID;
        }
        public string getPrizeID()
        {
            return this.prizeID;
        }
       
        public void addPrize(int quantity)
        {
           currentAvailable += quantity;
        }
        public void Decrease(int noofprize)
        {
            currentAvailable -= noofprize;
        }
       
        public void ClearPrize()
        {
            this.currentAvailable = 0;
        }

    }
}
