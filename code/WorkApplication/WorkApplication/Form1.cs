using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WorkApplication.Config;
using System.ComponentModel.DataAnnotations;

namespace WorkApplication
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("EYcECbJVRr");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 50 || textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a valid FIRST name, not more than 50 characters and it should be more than 1 character!");
                return;
            }
            if (textBox2.Text.Length > 50 || textBox2.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a valid LAST name, not more than 50 characters and it should be more than 1 character!");
                return;
            }
            if (new EmailAddressAttribute().IsValid(textBox3.Text) == false)
            {
                MessageBox.Show("Please enter a valid email address!");
                return;
            }

            var isNumeric = long.TryParse(textBox4.Text, out long n);
            if ((textBox4.Text.Length > 10 || textBox4.Text.Length < 10) && isNumeric)
            {
                MessageBox.Show("Please enter a valid Nigerian 10 digit phone number!");
                return;
            }
            bool checkIfSameMale = String.Equals(textBox5.Text, "Male");
            bool checkIfSameFemale = String.Equals(textBox5.Text, "Female");

            if (!(checkIfSameMale || checkIfSameFemale))
            {
                MessageBox.Show("Please enter either 'Male' or 'Female'!");
                return;
            }

            // saves data in the database
            db.Execute($"INSERT INTO `user_info` (`First Name`, `Last Name`, `Email`, `Phone Number`, `Gender (Male/Female)`) VALUES ( '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}' )" );

            MessageBox.Show("Submitted Successfully!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
