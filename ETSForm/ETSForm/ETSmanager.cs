using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ETS_Project
{
    public class ETSmanager
    {
        public ETSmanager() { }

        donors mydonors = new donors();
        sponsors mysponsors = new sponsors();
        Donations mydonations = new Donations();
        Prizes myprizes = new Prizes();

        public void writeDonors()
        {
            string str = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\LASALLE COLLEGE\SEMESTER 3\Multi tier Applications\donor.txt"))
                {
                    foreach (Donor donor in mydonors)
                    {
                        sw.Write(donor.toString());
                    }
                    str = "saved record successfully";
                }
            }
            catch(Exception ex)
            {
                str=ex.Message;
            }
             
        }
       
        public void getDonors()
        {
            readDonor();
        }

        public bool donoridverifier(string donorid)
        {
            bool flag = false;
            foreach (Donor donor in mydonors)
            {
                if (donor.getid() == donorid)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public bool prizeidVerifier(string pid)
        {
            bool flag = false;
            foreach (Prize prize in myprizes)
            {
                if (prize.getPrizeID() == pid)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool sponsoridverifier(string sid)
        {
            bool flag = false;
            string msg = "";
            foreach (sponsor sponsor in mysponsors)
            {
                if (sponsor.getID() == sid)
                {
                    flag = true;
                }
            }
            return flag;

        }
        public bool donationidVerifier(string donid)
        {
            bool flag = false;
            string msg = "";
            foreach (Donation donation in mydonations)
            {
                if (donation.getid() == donid)
                {
                    flag = true;
                }
            }
            return flag;
        }

        Regex reg = new Regex("^[0-9]\\d{2}[-][0-9]\\d{2}[-]\\d{4}$");
        
        public bool validatePhonenumber(string number)
        {
            bool flag = false;
          
            if (!(reg.IsMatch(number)))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        public const string cardno = @"^\(?[0-9]{4}\)?[-]?([0-9]{4}\)?[-]?([0-9]{4}\)?[-]?([0-9]{4}))$";

        public bool validatecardno(string number)
        {
            bool flag = false;

            if (Regex.IsMatch(number, cardno))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        public const string expirydate = @"^\[0 - 3]?[0 - 9].[0 - 3]?[0 - 9].([0 - 9]{2})?[0 - 9]{2}$";


        public bool validateexpirydate(string number)
        {
            bool flag = false;

            if (Regex.IsMatch(number, expirydate))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        public const string pattern = @"^[VMAvma]{1}*$";
        
       
     /*   public bool validatecardtype(string number)
        {
            bool flag = false;

            if (Regex.IsMatch(number, pattern))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }*/
        public void readDonor()
        {
            using(StreamReader sr=new StreamReader(@"D:\LASALLE COLLEGE\SEMESTER 3\Multi tier Applications\donor.txt"))
            {
                while(sr.Peek() >= 0)
                {
                    string str=sr.ReadLine();
                    string[] strarray;
                    str = sr.ReadLine();

                    strarray= (str.Split(',') as string[]);
                    Donor donor = new Donor(strarray[0], strarray[1], strarray[2], strarray[3], strarray[4], Convert.ToChar(strarray[5]), strarray[6], strarray[7]);
                    mydonors.add(donor);
                }
                foreach(Donor donor in mydonors)
                {
                    donor.toString();
                }
            }
        }
        public string adddonor(string donorid, string lastname, string firstname, string address, string phone, char cardtype, string cardnumber, string cardexpiry)
        {
            string msg = "";
            if (donorid.Length != 4)
            {
                msg = "error!length should be 4 characters";
            }
            else
            {
                if (donoridverifier(donorid) == true)
                {
                    msg = "id already exists! ";
                }
                else
                {
                    if (lastname.Length > 15)
                    {
                        msg = "Error !last name length should be  fifteen";
                    }
                    else
                    {
                        if (firstname.Length > 15)
                        {
                            msg = "Error !last name length should be  fifteen";
                        }
                        else
                        {
                            if (address.Length > 40)
                            {
                                msg = "Address should be 40 characters";

                            }
                            else
                            {
                                if (validatePhonenumber(phone) == false)
                                {
                                    msg = "Phone number is not valid";
                                }
                                else
                                {
                                     if (validatecardno(cardno)==false)
                                        {
                                            msg = "Invalid credit card number please try again";
                                        }
                                        else
                                        {
                                            if (validateexpirydate(expirydate) == false)
                                            {
                                                msg = "Error !invalid expiry date....";
                                            }
                                           

                                            Donor donor = new Donor(donorid,firstname, lastname, address, phone, cardtype, cardnumber, cardexpiry);
                                            mydonors.add(donor);
                                            msg = "donor added successfully!";
                                        }

                                    
                                }

                            }
                        }
                    }


                }

            }
            return msg;

        }
        public string ListDonors()
        {
            string msg = "";
            foreach (Donor donor in mydonors)
            {
                msg += donor.toString();
                msg += Environment.NewLine;
            }
            return msg;
        }

        public string savedonorinfor()
        {
            string msg = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\\LASALLE COLLEGE\\SEMESTER 3\\Multi tier Applications\\donor.txt"))
                {
                    foreach (Donor donor in mydonors)
                    {
                        sw.WriteLine(donor.toString());
                    }
                    msg = "record added suceesfully";

                }
                
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
            }
            return msg;
        }

        public string getSponsoridfromPrizeid(string prizeId)
        {
            string sponsorid = "";
            foreach (Prize prize in myprizes)
            {
                if (prize.getPrizeID() == prizeId)
                {
                    sponsorid = prize.SponsorID;
                }

            }
            return sponsorid;
        }
        public void calculatetotValue(string sponsorid, double value,int originalAvailable)
        {

            foreach (sponsor sponsor in mysponsors)
            {
                if (sponsor.getID() == sponsorid)
                {
                    sponsor.calculateTotalValue(value,originalAvailable);
                }
            }


        }

        


        public string addsponsor(string firstname, string lastname, string sponsorID)
        {
            string msg = "";


            if (firstname.Length > 15)
            {
                msg = "Error! Firstname should be 15 characters!!";
            }
            else
            {
                if (lastname.Length > 15)
                {
                    msg = "Error! lastname should be 15 characters!!";
                }
                else
                {
                    if (sponsorID.Length != 4)
                    {
                        msg = "Error!id should be of  4 characters";
                    }
                    else
                    {
                        if (sponsoridverifier(sponsorID) == true)
                        {
                            msg = "id already exists";
                        }
                        else
                        {

                            sponsor sponsor = new sponsor(firstname, lastname, sponsorID, 0.0);
                            mysponsors.add(sponsor);
                            msg = "sponsor added successfully!!!";

                        }
                    }
                }
            }
            return msg;
        }

        public string AddPrize(string prizeId, string description, double value, int noofprizes, double donationLimit,
          string sponsorId)
        {
            string msg = "";
            if (prizeId.Length != 4)
            {
                msg = "Length of the id should be 4 charactres";
            }
            else
            {
                if (prizeidVerifier(prizeId) == true)
                {
                    msg = "id already exists";
                }
                else
                {
                    if (description.Length > 15)
                    {
                        msg = "description should be 15 characters";
                    }
                    else
                    {
                        if (value > 299.99)
                        {
                            msg = "prize should be below 299.99";
                        }
                        else
                        {
                            if (noofprizes > 999)
                            {
                                msg = "no of prizes cannot be more than 999";

                            }
                            else
                            {
         

                                calculatetotValue(sponsorId,  value, noofprizes);

                                Prize prize = new Prize(prizeId, description, value, donationLimit, noofprizes,  sponsorId);
                                myprizes.add(prize);
                                msg = "prize added successfully";
                            }


                        }
                    }
                }

            }
            return msg;

        }

        public string Listsponsorinfo()
        {
            string msg = "";
            foreach (sponsor spon in mysponsors)
            {
                msg += spon.toString();
                msg += Environment.NewLine;
            }
            return msg;
        }

        public void ListSponsor()
        {
            foreach (sponsor sponsor in mysponsors)
            {
                sponsor.toString();
            }
        }



        public string addDonation(string donationID, string donorID, string prizeID, double
            donationAmount)

        {
            string msg = "";
            string prizeId = "";
            if (donationID.Length != 4)
            {
                msg = "ID length should be 4 characters";
            }
            else
            {
                if (donationidVerifier(donationID) == true)
                {
                    msg = "ID already exists";
                }
                else
                {
                    if (donoridverifier(donorID) == false)
                    {
                        msg = "The donor id enetered is incorrect";
                    }
                    else
                    {
                        if (donationAmount < 5.00 && donationAmount > 999999.99)
                        {
                            msg = "invalid amount!Please enter a valid amount";
                        }

                        else
                        {
                            int noofprizes = ListqualifiedPrizes(donationAmount);
                            if (prizeidVerifier(prizeID) == false)
                            {
                                msg = "The prizeid enterd is wrong";
                            }
                            DateTime date = DateTime.Now;
                            Donation donation = new Donation(donationID, Convert.ToString(date), donorID, donationAmount, prizeID);
                            
                            if (RecordDonation(prizeID, Convert.ToInt32(noofprizes), Convert.ToDouble(donationAmount)) == true)
                            {
                                mydonations.add(donation);
                                msg = "donation made successfully";

                            }
                            else
                            {
                                msg = "donation not made";


                            }

                        }

                    }


                }

            }
            return msg;
        }

        public string Listdonations()
        {
            string msg = "";
            foreach (Donation donation in mydonations)
            {
                msg += donation.toString();
                msg += Environment.NewLine;
            }
            return msg;
        }
      

        
        public string Listprizes()
        {
            string msg = "";
            foreach (Prize prize in myprizes)
            {
                msg += prize.toString();
                msg += Environment.NewLine;
            }
            return msg;
        }
        public string findSponsor(string stringid)
        {
            string msg = "";
            foreach(sponsor  sponsor in mysponsors)
            {
                if(sponsor.getID() == stringid)
                {
                    msg=sponsor.SponsorID;
                }
                else
                {
                    msg = "sponsor id doesnot exists";
                }
            }
            return msg;
        }
        public string findPrize(string prizeid)
        {
            string msg = "";
            foreach (Prize prize in myprizes)
            {
                if (prize.getPrizeID() == prizeid)
                {
                    msg = prize.PrizeID;
                }
                else
                {
                    msg = "prize id doesnot exists";
                }
            }
            return msg;
        }

        public string findDonor(string donorid)
        {
            string msg = "";
            foreach (Donor donor in mydonors)
            {
                if (donor.getid() ==donorid)
                {
                    msg = donor.DonorID;
                }
                else
                {
                    msg = "donor id doesnot exists";
                }
            }
            return msg;
        }

        public string findDonation(string donationid)
        {
            string msg = "";
            foreach(Donation donation in mydonations)
            {
                if(donation.getid() == donationid)
                {
                    msg=donation.DonationID;
                }
                else
                {
                    msg = "donation id does not exist";
                }
            }
            return msg;
        }
        public string displayOnesponsor(string sponsorid)
        {
            string msg = "";
            foreach(sponsor sponsor in mysponsors)
            {
                if (sponsor.getID() == sponsorid)
                {
                    msg = sponsor.toString();
                }
                else
                {
                    msg = "sponsor doesnot exist";
                }
            }
            return msg;
        }

        public string displayOnePrize(string prizeid)
        {
            string msg = "";
            foreach(Prize prize in myprizes)
            {
                if(prize.getPrizeID() == prizeid)
                {
                    msg = prize.toString();
                }
                else
                {
                    msg = "prize doesnot exist";
                }
            }
            return msg;
        }

        public int ListqualifiedPrizes(double donationamount)
        {
            int num = 0;
            foreach (Prize prize in myprizes)
            {
                if (prize.DonationLimit <= donationamount)
                {
                    num = (int)(donationamount / prize.DonationLimit);
                    Console.WriteLine("Prizeid: " + prize.PrizeID + " " + " qualified peizes: " + num);
                }

            }
            return num;
        }





        public bool RecordDonation(string prizeid, int num, double donationamount)
        {


            foreach (Prize prize in myprizes)
            {
                int numofqulifiedprizes = (int)(donationamount / prize.DonationLimit);
                if (prize.getPrizeID() == prizeid)
                {

                    if (num <= numofqulifiedprizes && num <= prize.Currentavailable)
                    {

                        prize.Decrease(num);
                        return true;

                    }

                }
            }
            return false;
        }

        /*public bool RecordDonation(string prizeid, int numofprizesawarded, double donationamount, string donorid)
        {


            foreach (Prize prize in myprizes)
            {
                int numofqulifiedprizes = (int)(donationamount / prize.DonationLimit);
                if (prize.getPrizeID() == prizeid)
                {
                    if (numofprizesawarded <= numofqulifiedprizes && prize.Currentavailable >= numofprizesawarded)
                    {

                        prize.Decrease(numofprizesawarded);
                        return true;

                    }

                }
            }
            return false;
        }*/
    }
}

   

