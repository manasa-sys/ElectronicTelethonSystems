using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_Project
{
     class Donor:Person
    {
        string donorID;
        string address;
        string phone;
        char cardType;
        string cardnumber;
        string expiry;

        public Donor(string donorID, string firstname, string lastname, string address, string phone, char cardType, string cardnumber, string expiry):base(firstname,lastname)
        {
            this.donorID = donorID;
            this.address = address;
            this.phone = phone;
            this.cardType = cardType;
            this.cardnumber = cardnumber;
            this.expiry = expiry;
        }
        public string DonorID
        {
            get { return this.donorID; }
            set { this.donorID = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public char CardType
        {
            get { return this.cardType; }
            set { this.cardType = value; }
        }
        public string Cardnumber
        {
            get { return this.cardnumber; }
            set { this.cardnumber = value; }
        }
        public string Expiry
        {
            get { return this.expiry; }
            set { this.expiry = value; }
        }
        public string toString()
        {
            return base.toString()+" "+"donorid:"+
                this.donorID+" "+"address:"+this.address+" "+"phone:"+ this.phone+" "+ "cardtype:"+this.cardType+" "+"cardnumber"+
                this.cardnumber+" "+"expiry:"+this.expiry;
        }
        public string getid()
        {
            return donorID;
        }


    }

}
