using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            Button zeroButton = (Button)sender;
            label1.Text += zeroButton.Text;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Button oneButton = (Button)sender;
            label1.Text += oneButton.Text;
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Button twoButton = (Button)sender;
            label1.Text += twoButton.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button threeButton = (Button)sender;
            label1.Text += threeButton.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button fourButton = (Button)sender;
            label1.Text += fourButton.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button fiveButton = (Button)sender;
            label1.Text += fiveButton.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button sixButton = (Button)sender;
            label1.Text += sixButton.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button sevenButton = (Button)sender;
            label1.Text += sevenButton.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button eightButton = (Button)sender;
            label1.Text += eightButton.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button nineButton = (Button)sender;
            label1.Text += nineButton.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button plusButton = (Button)sender;
            label1.Text += plusButton.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                //creates a datatable needed for solving
                DataTable table = new DataTable();

                //creates the result
                var result = table.Compute(label1.Text, "");

                //sets the label text to the result
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = "Error";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button minusButton = (Button)sender;
            label1.Text += minusButton.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button multiButton = (Button)sender;
            label1.Text += multiButton.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button divideButton = (Button)sender;
            label1.Text += divideButton.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button pointButton = (Button)sender;
            label1.Text += pointButton.Text;
        }
    }
}
