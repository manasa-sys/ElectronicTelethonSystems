using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Project
{
     class Donation
    {
        string donationID;
        string donationdate;
        string donorID;
        double donationAmount;
        string prizeID;

        public Donation(string donationID, string donationdate, string donorID, double donationAmount, string prizeID)
        {
            this.donationID = donationID;
            this.donationdate = donationdate;
            this.donorID = donorID;
            this.donationAmount = donationAmount;
            this.prizeID = prizeID;
        }
        public string DonationID
        {
            get { return this.donationID; }
            set { this.donationID = value; }
        }
        public string Donationdate
        {
            get { return this.donationdate; }
            set { this.donationdate = value; }
        }
        public string DonorID
        {
            get { return this.donorID; }
            set { this.donorID= value; }
        }
        public double DonationAmount
        {
            get { return this.donationAmount; }
            set { this.donationAmount = value; }
        }
        public string PrizeID
        {
            get { return this.prizeID; }
            set { this.prizeID = value; }
        }
        public string toString()
        {
            return "DontionID:"+this.donationID + " "+"donationId:"+this.donationID + " "+"donationamount:"+this.donationAmount +
                " "+"Prizeid:"+this.PrizeID;
        }
        public string getid()
        {
            return donationID;
        }
        
    }
}
