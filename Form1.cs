using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_machine
{
    public partial class Form1 : Form
    {
        public string what = " ";
        public string one = "1";
        public string two = "2";
        public string three = "3";
        public string four = "4";
        public string five = "5";
        public string six = "6";
        public string seven = "7";
        public string eight = "8";
        public string nine = "9";
        public string zero = "0";
        public int a, b;
        public Form1()
        {
            InitializeComponent();
            TextBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = one;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + one;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = two;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + two;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = three;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + three;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = four;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + four;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = five;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + five;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = six;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + six;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = seven;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + seven;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = eight;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + eight;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = nine;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + nine;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                
            }
            else
            {
                TextBox1.Text = TextBox1.Text + zero;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            TextBox1.Text = null;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            what = "subtraction";
            a = int.Parse(TextBox1.Text);
            TextBox1.Text = null;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            what = "addition";
            a = int.Parse(TextBox1.Text);
            TextBox1.Text = null;
        }

        private void division_Click(object sender, EventArgs e)
        {
            what = "division";
            a = int.Parse(TextBox1.Text);
            TextBox1.Text = null;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            what = "multiplication";
            a = int.Parse(TextBox1.Text);
            TextBox1.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            b = int.Parse(TextBox1.Text);
            var calc = new Calculator();
            if (what == "subtraction")
            {
                var x = calc.subtraction(a, b);
                TextBox1.Text = x.ToString();
            }
            else if (what == "addition")
            {
                var x = calc.addition(a, b);
                TextBox1.Text = x.ToString();
            }
            else if (what == "division")
            {
                var x = calc.division(a, b);
                TextBox1.Text = x.ToString();
            }
            else if (what == "multiplication")
            {
                var x = calc.multiolication(a, b);
                TextBox1.Text = x.ToString();
            }
            else if (what == " ")
            {
                a = int.Parse(TextBox1.Text);
                TextBox1.Text = a.ToString();
            }
        }
    }
}
