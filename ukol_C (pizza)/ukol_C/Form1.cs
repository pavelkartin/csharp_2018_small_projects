using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_C
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

            int celkem = 0;

            if (rbVelka.Checked == true)
            {
                celkem = celkem +150;
            }

            if (rbStredni.Checked == true)
            {
                celkem = celkem + 100;
            }

            if (rbMala.Checked == true)
            {
                celkem = celkem + 50;
            }

            if (chHouby.Checked == true)
            {
                celkem = celkem + 10;
            }

            if (chSalam.Checked == true)
            {
                celkem = celkem + 10;
            }

            if (chAncovicky.Checked == true)
            {
                celkem = celkem + 10;
            }
            
            textBox1.Text = celkem + " Kč";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            rbVelka.Checked = false;
            rbStredni.Checked = false;
            rbMala.Checked = false;
            chHouby.Checked = false;
            chSalam.Checked = false;
            chAncovicky.Checked = false;
        }
    }
}
