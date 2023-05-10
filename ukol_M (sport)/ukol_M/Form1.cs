using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_M
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
            int sparta = Convert.ToInt32(textBox1.Text);
            int slavie = Convert.ToInt32(textBox2.Text);

            if (sparta > slavie)
            {
                MessageBox.Show("Sparta vyhrála se skórem " + sparta + ":" + slavie);
            }

            if (sparta == slavie)
            {
                MessageBox.Show("Utkání Sparta-Slavia skončilo remízou " + sparta + ":" + slavie);
            }

            if (sparta < slavie)
            {
                MessageBox.Show("Slavie vyhrála se skórem " + slavie + ":" + sparta);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);

            //limit
            if (a > 99)
                textBox1.Text = "99";

            else if (a < 0)
                textBox1.Text = "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox2.Text);

            //limit
            if (b > 99)
                textBox1.Text = "99";

            else if (b < 0)
                textBox1.Text = "0";
        }
    }
}
