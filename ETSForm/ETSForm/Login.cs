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
    public partial class Login : Form
    {
        int noOfAttempts = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
           
            if(logintxt.Text!="ETS" || passtxt.Text != "admin")
            {
                msg = "incorrect username or password";
                MessageBox.Show(msg);
                noOfAttempts++;
                logintxt.Clear();
                passtxt.Clear();
              
            }
            else
            {
                mainForm main = new mainForm();
                main.ShowDialog();
            }
            if (noOfAttempts == 3)
            {
                Application.Exit();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

       
    }
