using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string num1;
        string num2;
        int f ;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text+"0" ;
            if (f == 4)
            {
                textBox1.Text = "0";
                f = 5;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"1" ;
            if (f == 4)
            {
                textBox1.Text = "1";
                f = 5;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"2" ;
            if (f == 4)
            {
                textBox1.Text = "2";
                f = 5;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"3";
            if (f == 4)
            {
                textBox1.Text = "3";
                f = 5;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"4";
            if (f == 4)
            {
                textBox1.Text = "4";
                f = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"5";
            if (f == 4)
            {
                textBox1.Text = "5";
                f = 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"6";
            if (f == 4)
            {
                textBox1.Text = "6";
                f = 5;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"7";
            if (f == 4)
            {
                textBox1.Text = "7";
                f = 5;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"8";
            if (f == 4)
            {
                textBox1.Text = "8";
                f = 5;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"9";
            if(f==4)
            {
                textBox1.Text = "9";
                f = 5;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            f = 0;
            textBox1.Text = null;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            f = 1;
            textBox1.Text = null;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            f = 2;
            textBox1.Text = null;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            f = 3;
            textBox1.Text = null;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (f == 0&& textBox1.Text!=null)
            {
                num2 = textBox1.Text;
                int num11 = Convert.ToInt32(num1);
                int num22 = Convert.ToInt32(num2);
                int re = num11 * num22;
                string res= Convert.ToString(re);
                textBox1.Text = res;
            }
            if (f == 1 && textBox1.Text != null)
            {
                num2 = textBox1.Text;
                int num11 = Convert.ToInt32(num1);
                int num22 = Convert.ToInt32(num2);
                int re = num11 / num22;
                string res = Convert.ToString(re);
                textBox1.Text = res;
            }
            if (f == 2 && textBox1.Text != null)
            {
                num2 = textBox1.Text;
                int num11 = Convert.ToInt32(num1);
                int num22 = Convert.ToInt32(num2);
                int re = num11 - num22;
                string res = Convert.ToString(re);
                textBox1.Text = res;
            }
            if (f == 3 && textBox1.Text != null)
            {
                num2 = textBox1.Text;
                int num11 = Convert.ToInt32(num1);
                int num22 = Convert.ToInt32(num2);
                int re = num11 + num22;
                string res = Convert.ToString(re);
                textBox1.Text = res;
            }
            f = 4;
        }
    }
}