using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS_Project;

namespace ETSForm
{
    public partial class mainForm : Form
    {
        ETSmanager man = new ETSmanager();
        public mainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addspntxt_Click(object sender, EventArgs e)
        {
            string msg = man.addsponsor(sfntxt.Text, slntxt.Text, sidtxt.Text);
            MessageBox.Show(msg);
            sfntxt.Clear();
            slntxt.Clear();
            sidtxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string msg = man.Listsponsorinfo();
            richTextBox1.AppendText(msg);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string msg = man.AddPrize(pidtxt.Text, pdtxt.Text, Convert.ToDouble(pvtxt.Text),Convert.ToInt32(notxt.Text),Convert.ToDouble(dontxt.Text), sidftext.Text);
            MessageBox.Show(msg);
            pidtxt.Clear(); 
            pdtxt.Clear();
            pvtxt.Clear();
            notxt.Clear();
            dontxt.Clear();
            sidftext.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = man.Listprizes();
            richTextBox1.AppendText(msg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string msg = man.addDonation(donationidtxt.Text, didtxt.Text, prizeidtxt.Text,
            Convert.ToDouble(amountxt.Text));
            MessageBox.Show(msg);
            donationidtxt.Clear();
            didtxt.Clear();
            prizeidtxt.Clear();
            amountxt.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           int msg = man.ListqualifiedPrizes(Convert.ToDouble(amountxt.Text));
            MessageBox.Show(Convert.ToString(msg));
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string msg=man.Listdonations();
            richTextBox1.AppendText(msg);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string msg = man.savedonorinfor();
            MessageBox.Show(msg);
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string msg=man.ListDonors();
            richTextBox1.AppendText(msg);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string type;
            if (VISA.Checked)
            {
                type = "VISA";
            }
            
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (MC.Checked)
            {
                type = 'M';
            }
        }
            private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        char type = ' ';
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (VISA.Checked == true)
            {
                type = 'V';
            }
        }

        private void AMEX_CheckedChanged(object sender, EventArgs e)
        {
          
            if (AMEX.Checked==true)
            {
                type = 'A';
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string msg = man.adddonor(didtxt.Text, dfntxt.Text, dlntxt.Text, daddtxt.Text, dphonetxt.Text,
              Convert.ToChar(type),cardnotxt.Text, cetxt.Text);
            MessageBox.Show(msg);
            didtxt.Clear();
            dfntxt.Clear();
            dlntxt.Clear();
            daddtxt.Clear();
            dphonetxt.Clear();
            cardnotxt.Clear();
            cetxt.Clear();

        }

        /*public char cardtype()
        {
            char type;
            type=man.checkcardtype();
            return type;

        }*/
        /*private object checkcardtype()
        {
            throw new NotImplementedException();
        }*/

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string msg = man.findSponsor(sidtxt.Text);
            MessageBox.Show(msg);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string msg = man.displayOnesponsor(sidtxt.Text);
            MessageBox.Show(msg);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string msg=man.findDonor(didtxt.Text);
            MessageBox.Show(msg);
        }

        private void findprizetxt_Click(object sender, EventArgs e)
        {
            string msg = man.findPrize(pidtxt.Text);
            MessageBox.Show(msg);
        }

        private void disprizetxt_Click(object sender, EventArgs e)
        {
            string msg = man.displayOnePrize(pidtxt.Text);
            MessageBox.Show(msg);

            
        }

        private void finddontxt_Click(object sender, EventArgs e)
        {
            string msg = man.findDonation(donationidtxt.Text);
            MessageBox.Show(msg);   
              
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
