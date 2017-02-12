/// Author : Mayank Bhardwaj
/// Student	ID : 200305245
/// Date : 02-12-2017
/// App description : This app determines the total	amount due for the purchase	of a 
///                   vehicle based on accessories and options selected. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Comp1004
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        // To calaculate the whole amount
        private void claculateButton_Click(object sender, EventArgs e)
        {
            Double BasePrice = Convert.ToDouble(textBox1.Text);
            Double SubTotal, Total, Allownace, AmountDue;
            Double AdditionalOptions = 0;
            if (checkBox1.Checked == true)
            {
                AdditionalOptions = AdditionalOptions + 425.76;
            }
            if (checkBox2.Checked == true)
            {
                AdditionalOptions = AdditionalOptions + 987.41;
            }
            if (checkBox3.Checked == true)
            {
                AdditionalOptions = AdditionalOptions + 1741.23;
            }
            if (radioButton2.Checked == true)
            {
                AdditionalOptions = AdditionalOptions + 345.72;
            }
            if (radioButton3.Checked == true)
            {
                AdditionalOptions = AdditionalOptions + 599.99;
            }
            textBox2.Text = AdditionalOptions.ToString();
            SubTotal = AdditionalOptions + BasePrice;
            textBox3.Text = SubTotal.ToString();
            textBox4.Text = CalTax(SubTotal).ToString();
            Total = CalTax(SubTotal) + SubTotal;
            textBox5.Text = Total.ToString();
            Allownace = Convert.ToDouble(textBox6.Text);
            AmountDue = Total - Allownace;
            textBox7.Text = AmountDue.ToString();
        }
        private double CalTax(double Amount)
        {
            Amount = Amount * 0.13;
            return Amount;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new form
            AboutForm aboutForm = new AboutForm();

            //show the about form with dialog 
            aboutForm.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            claculateButton_Click(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = "0";
            textBox7.Text = " ";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem_Click(sender, e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
