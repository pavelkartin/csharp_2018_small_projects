using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool activated = false;

        Rectangle r;
        Graphics g;

        Timer t = new Timer();

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Rectangle(0, 0, 50, 50);
            g = this.CreateGraphics();

            t.Interval = 10;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (activated == true)
            {
                g.Clear(SystemColors.Control);
                g.FillRectangle(new SolidBrush(Color.Red), r);

                r.X += 1;
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            activated = true;

            r.X = 0;
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            activated = false;
        }
    }
}
