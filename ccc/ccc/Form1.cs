using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = ("You are not allowed to calculate without 2 values");
                //  MessageBox.Show("not allowed");
                label5.Visible = true;
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float sum = num1 + num2;
                label5.Text = sum.ToString();
                label5.Visible=true;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = ("You are not allowed to calculate without 2 values");
                label5.Visible = true;
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int remain = num1 % num2;
                label5.Text = remain.ToString();
                label5.Visible=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = ("You are not allowed to calculate without 2 values");
                label5.Visible = true;
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int subtract = num1 - num2;
                label5.Text = subtract.ToString();
                label5.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = ("You are not allowed to calculate without 2 values");
                   label5.Visible = true;
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int mult = num1 * num2;
                label5.Text = mult.ToString();
                label5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = ("You are not allowed to calculate without 2 values");
                label5.Visible = true;
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float divide = num1 / num2;
                label5.Text = divide.ToString();
                label5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = ("You are not allowed to calculate without 2 values");
                label5.Visible = true;
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                double power = Math.Pow(num1,num2);
                label5.Text = power.ToString();
                label5.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
