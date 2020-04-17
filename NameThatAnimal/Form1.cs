using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatAnimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            string letter = (txtletter.Text).Substring(0, 1);
            Regex valid = new Regex("^[a-z]$");

            if (valid.IsMatch(letter))
            {
                switch(letter)
                {
                    case "a":
                        lstbx.Items.Add("Armadillo, a desert mammal with a characteristic hard shell for protection");
                        break;

                    case "b":
                        lstbx.Items.Add("bear, a large mammal with thick fur which usually feeds on salmon");
                        break;

                    case "c":
                        lstbx.Items.Add("cat, a small mammmal with fur, usually domesticated");
                        break;

                    case "d":
                        lstbx.Items.Add("dog, a usually domesticated mammal with lots of different breeds");
                        break;

                    case "e":
                        lstbx.Items.Add("eel, a long slim aquatic animal with no fins");
                        break;

                    default:
                        MessageBox.Show("Hmmmm, i cant think of one");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter a single lower case letter");
            }
                
        }

        private void lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngen_Click(object sender, EventArgs e)
        {
            string number = (txtscore.Text).Substring(0, 1);

                switch (number)
                {
                    case "1":
                        lblcomment.Text = "This work is completely inadequate";
                        break;

                    case "2":
                        lblcomment.Text = "This work is not executed well at all";
                        break;

                    case "3":
                        lblcomment.Text = "This work is not sufficient, re do this";
                        break;

                    case "4":
                        lblcomment.Text = "This work is not particularly good at all";
                        break;

                    case "5":
                        lblcomment.Text = "This work is below average";
                        break;

                    case "6":
                        lblcomment.Text = "this work is average";
                        break;

                    case "7":
                        lblcomment.Text = "this work is above average";
                        break;

                    case "8":
                        lblcomment.Text = "this work is good";
                        break;

                    case "9":
                        lblcomment.Text = "this work is excellent";
                        break;

                    case "10":
                        lblcomment.Text = "this work is outstanding";
                        break;

                    default:
                        MessageBox.Show("please enter a number between one and ten");
                        break;
                }

        }
    }
}
