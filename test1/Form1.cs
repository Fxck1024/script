using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        string type = "";
        string x = "";
        string y = "";
        double z = 0;
        double n = 0;
        double s = 0;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 1;
            y += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 2;
            y += 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 3;
            y += 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 4;
            y += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 5;
            y += 5;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 6;
            y += 6;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 7;
            y += 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 8;
            y += 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 9;
            y += 9;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "";
                flag = false;
            }
            label1.Text += 0;
            y += 0;
            if (type == "/")
            {
                label1.Text = "除数不能为零";
                flag = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Text = "0";
            flag = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(x))
            {
                n = double.Parse(x);
                s = double.Parse(y);
                switch (type)
                   {
                        case "+": z = n + s; break;
                        case "-": z = n - s; break;
                        case "*": z = n * s; break;
                        case "/": z = n / s; break;

                    }
                    label1.Text = z.ToString();
                flag = true;
            }
                
            else { label1.Text = "输入有误"; flag = true; }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = label1.Text;
            label1.Text += "+";
            type = "+";
            y = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = label1.Text;
            label1.Text += "*";
            type = "*";
            y = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            x = label1.Text;
            label1.Text += "-";
            type = "-";
            y = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = label1.Text;
            label1.Text += "/";
            type = "/";
            y = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
            y += ".";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = label1.Text;
            if(s.Length != 0)
            {
                label1.Text = s.Substring(0, s.Length - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
