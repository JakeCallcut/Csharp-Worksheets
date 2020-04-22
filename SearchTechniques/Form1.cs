using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTechniques
{
    public partial class Form1 : Form
    {            
        String[] names = {"Alex", "Bob", "Cathrine", "Debora", "Evelyn", "Frank", "Harry", "Jane", "Linda", 
            "Oliver", "Pedro", "Quentin", "Robert", "Terry", "Victoria"};
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnbin_Click(object sender, EventArgs e)
        {
            string searchterm = txtsrcitem.Text;
            int position;
            bool found = false;

            searchterm = searchterm.ToLower();
            position = names.Length / 2;
            do
            {

                if (searchterm == names[position])
                {
                    MessageBox.Show(searchterm + " was in position " + position + 1);
                    found = true;
                }
                else if (String.Compare(searchterm, names[position].ToLower()) > 0 )
                {
                    position += position / 2;
                }
                else if (String.Compare(searchterm.Substring(0, 1), names[position].Substring(0, 1).ToLower()) < 0)
                {
                    position -= position / 2;
                }

                if (position == names.Length)
                {
                    MessageBox.Show(searchterm + " was not found in the list");
                    break;
                }

            } while (found == false);

        }
        public Form1()
        {
            InitializeComponent();
        }    

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < names.Length; i++)
            {
                lstbx.Items.Add(names[i]);
            }
        }

        private void btnser_Click(object sender, EventArgs e)
        {
           string searchterm = txtsrcitem.Text;
            bool found = false;
            int position = 0;

            do
            {
                if (searchterm == names[position])
                {
                    MessageBox.Show(searchterm + " was in position " + (position + 1));
                    found = true;
                    position++;
                }
                else
                {
                    position++;
                    found = false;
                }

                if (position == names.Length);
                {
                    MessageBox.Show(searchterm + " was not found in the list");
                    break;
                }
            } while (found == false);
        }
    }
}
