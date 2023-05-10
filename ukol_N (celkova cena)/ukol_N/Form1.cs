using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        
        
        ////uprava
        private void tbKus1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void tbKusC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void tbKus2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void tbKusC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void tbPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }

        private void tbBal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) // ! - krome, 8 - backspace, 46 - delete
            {
                e.Handled = true; //poslat info
            }
        }
        
        ////limit
        private void tbKus1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKus1.Text))
            {
                int a = Convert.ToInt32(tbKus1.Text);

                if (a > 9999999)
                    tbKus1.Text = "9999999";

                else if (a < 0)
                    tbKus1.Text = "0";
            }
        }

        private void tbKusC1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKusC1.Text))
            {
                int a = Convert.ToInt32(tbKusC1.Text);

                if (a > 9999999)
                    tbKusC1.Text = "9999999";

                else if (a < 0)
                    tbKusC1.Text = "0";
            }
        }

        private void tbKus2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKus2.Text))
            {
                int a = Convert.ToInt32(tbKus2.Text);

                if (a > 9999999)
                    tbKus2.Text = "9999999";

                else if (a < 0)
                    tbKus2.Text = "0";
            }
        }

        private void tbKusC2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKusC2.Text))
            {
                int a = Convert.ToInt32(tbKusC2.Text);

                if (a > 9999999)
                    tbKusC2.Text = "9999999";

                else if (a < 0)
                    tbKusC2.Text = "0";
            }
        }

        private void tbPost_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPost.Text))
            {
                int a = Convert.ToInt32(tbPost.Text);

                if (a > 9999999)
                    tbPost.Text = "9999999";

                else if (a < 0)
                    tbPost.Text = "0";
            }
        }

        private void tbBal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBal.Text))
            {
                int a = Convert.ToInt32(tbBal.Text);

                if (a > 9999999)
                    tbBal.Text = "9999999";

                else if (a < 0)
                    tbBal.Text = "0";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKus1.Text) &&
                !string.IsNullOrEmpty(tbKusC1.Text) &&
                !string.IsNullOrEmpty(tbKus2.Text) &&
                !string.IsNullOrEmpty(tbKusC2.Text) &&
                !string.IsNullOrEmpty(tbPost.Text) &&
                !string.IsNullOrEmpty(tbBal.Text))
            {

                int kus1 = 0;
                int kus2 = 0;
                int cena1 = 0;
                int cena2 = 0;
                int post = 0;
                int balne = 0;

                int celkem = 0;


                kus1 = Convert.ToInt32(tbKus1.Text);
                kus2 = Convert.ToInt32(tbKus2.Text);
                cena1 = Convert.ToInt32(tbKusC1.Text);
                cena2 = Convert.ToInt32(tbKusC2.Text);
                post = Convert.ToInt32(tbPost.Text);
                balne = Convert.ToInt32(tbBal.Text);

                celkem = (cena1*kus1) + (cena2*kus2) + post + balne;
                MessageBox.Show("Celková cena je " + celkem + " Kč");
            }
            
        }
    }
}
