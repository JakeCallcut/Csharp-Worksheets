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
            const string userid = "JakeCallcut";
            const string password = "Password123";
            int attempts = 0;

            do
            {
                if (txtuser.Text == userid)
                {
                    if (txtpass.Text == password)
                    {
                        MessageBox.Show("Welcome!", "ACCESS GRANTED");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password", "ACCESS DENIED");
                        attempts++;
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect User ID", "ACCESS DENIED");
                    attempts++;
                }
                lblatt.Text = "Attempts: " + attempts + "/3";

            } while (attempts <= 3);
        }
    }
}
