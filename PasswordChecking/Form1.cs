using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChecking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            string userid = "JakeCallcut";
            string password = "Password123";
            int attempts = 0;

            do
            {
                if (txtuser.Text == userid)
                {
                    if (txtpass.Text == password)
                    {
                        lblacc.Text = "ACCESS GRANTED";
                    }
                    else
                    {
                        lblacc.Text = "incorrect password, ACCESS DENIED";
                        attempts++;
                    }

                }
                else
                {
                    lblacc.Text = "incorrect userid, ACCESS DENIED";
                    attempts++;
                }
                lblatt.Text = "Attempts: " + attempts + "/3";
                txtuser.Text = "";
                txtpass.Text = "";            

            } while (attempts <= 3);
        }
    }
}
