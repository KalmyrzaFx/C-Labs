using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int textBox1Num = Convert.ToInt32(textBox1.Text);
            int textBox2Num = Convert.ToInt32(textBox2.Text);
            int resForPlus = 0;
            int resForMinus = textBox1Num;
            int resForMull = 1;
            int resForDigit = textBox1Num;



            if (textBox3.Text == "+")
            {
                resForPlus = textBox1Num + textBox2Num;
                textBox4.Text = resForPlus.ToString();

            }

            if (textBox3.Text == "-")
            {
                resForMinus = resForMinus - textBox2Num;
                textBox4.Text = resForMinus.ToString();

            }

            if (textBox3.Text == "*")
            {
                resForMull = textBox1Num * textBox2Num;
                textBox4.Text = resForMull.ToString();

            }

            if (textBox3.Text == "/")
            {
                resForDigit = resForDigit / textBox2Num;
                textBox4.Text = resForDigit.ToString();

            }
        }
       
    }
}
