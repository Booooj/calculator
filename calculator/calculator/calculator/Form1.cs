using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxfirst.Text = boxfirst.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxsecond.Text = boxfirst.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boxthird.Text = boxthird.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boxfourth.Text = boxthird.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boxfifth.Text = boxthird.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            boxsixth.Text = boxthird.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            boxseventh.Text = boxthird.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            boxeighth.Text = boxthird.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            boxnineth.Text = boxthird.Text + "9";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            boxzero.Text = boxthird.Text + "0";
        }
    }
}
