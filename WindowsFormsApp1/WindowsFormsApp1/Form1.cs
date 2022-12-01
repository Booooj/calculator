using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_calculator : Form
    {
        public Form_calculator()
        {
            InitializeComponent();
        }

        private void Form_calculator_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            labeltime.Text = time.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            labeltime.Text = time.ToLongTimeString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
