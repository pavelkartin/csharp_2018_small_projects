using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.ReadOnly = true;
        }

        int cislo = 0;
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cislo + 1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cislo - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cislo = Convert.ToInt32(textBox1.Text);

            //limit
            if (cislo > 99999999)
                textBox1.Text = "99999999";//99 999 999

            else if (cislo < -99999999)
                textBox1.Text = "-99999999";
        }
    }
}
