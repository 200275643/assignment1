using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double percentageOfHoursWorked;
            double totalBonusAmount;
            double salesBonus;
            try
            {
                if (Convert.ToDouble(textBox3.Text) > 0 && Convert.ToDouble(textBox3.Text) <= 160)
                {

                    percentageOfHoursWorked = Convert.ToDouble(textBox3.Text) / 160;
                    totalBonusAmount = Convert.ToDouble(textBox4.Text) * 0.02;
                    salesBonus = percentageOfHoursWorked * totalBonusAmount;
                    textBox5.Text = salesBonus.ToString();
                    textBox4.Text = "$" + textBox4.Text;
                }
                else
                {
                    MessageBox.Show("Hours Worked: Enter a value from 0 to 160");
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                clearAll();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            clearAll();

        }

        private void clearAll()
        {
            textBox1.Focus();
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text) != "")
                MessageBox.Show("The form is being sent to the printer. Thank you!");

            else
                MessageBox.Show("Please fill the form");
        }

        private void MailOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
