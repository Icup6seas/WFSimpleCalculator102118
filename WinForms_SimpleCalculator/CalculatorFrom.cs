﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SimpleCalculator
{
    public partial class CalculatorFrom : Form
    {
        Double NumberOne;
        string Math;

        public CalculatorFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Math = "*";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Math = "-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Math = "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double NumberTwo;
            double Result;

            NumberTwo = Convert.ToDouble(textBox1.Text);

            if (Math == "+")
            {
                Result = (NumberOne + NumberTwo);
                textBox1.Text = Convert.ToString(Result);
                NumberOne = Result;
            }
            if (Math == "-")
            {
                Result = (NumberOne - NumberTwo);
                textBox1.Text = Convert.ToString(Result);
                NumberOne = Result;
            }
            if (Math == "*")
            {
                Result = (NumberOne * NumberTwo);
                textBox1.Text = Convert.ToString(Result);
                NumberOne = Result;
            }
        }
    }
}
