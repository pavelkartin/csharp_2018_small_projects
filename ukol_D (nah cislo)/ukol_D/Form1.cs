using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //jen 1-6

            if (Convert.ToInt32(textBox1.Text) < 1)
            {
                textBox1.Text = ("1");
            }

            if (Convert.ToInt32(textBox1.Text) > 6)
            {
                textBox1.Text = ("6");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Random rndGen = new Random();

                int tip = Convert.ToInt32(textBox1.Text);
                int hod = rndGen.Next(1, 7); //1-6

                if (tip <= hod || tip >= hod)
                {
                    vysledek.Text = "Jsi neuhodl/a.";
                    vysledek.ForeColor = Color.Red;
                }

                if (hod == tip)
                {
                    vysledek.Text = "Jsi uhodl/a!";
                    vysledek.ForeColor = Color.Green;
                }

                lblHod.Text = Convert.ToString(hod);
            }
        }
    }
}
