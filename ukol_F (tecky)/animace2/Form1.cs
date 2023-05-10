using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animace2
{
    public partial class Animace : Form
    {
        Graphics gr;       //grafika
        Pen p;             //pero
        SolidBrush fon;    //vypln
        SolidBrush fig;    //figura


        int rad;          // polomer
        Random rand;      // nah. cisla

        public Animace()
        {
            InitializeComponent();
        }

        //fce -> nakreslit
        void DrawCircle(int x, int y)
        {
            int xc, yc;
            xc = x - rad;
            yc = y - rad;
            gr.FillEllipse(fig, xc, yc, rad, rad);

            gr.DrawEllipse(p, xc, yc, rad, rad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();  //zobrazit 
                                                //+pripojit k PictureBox

            p = new Pen(Color.Green);                   // barva konturu 
            fon = new SolidBrush(SystemColors.Control); // bava vyplne
            fig = new SolidBrush(Color.Lime);

            rad = 40;                          //polomer pro kruh
            rand = new Random();               

            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height); //  vypln
                                                                                
            //=nakreslit

            int x, y;

            for (int i = 0; i < 20; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }

            timer1.Enabled = true;  //timer

        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {

            //vycistit pozadi
            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);


            // nahodne souradnice
            int x, y;

            for (int i = 0; i < 20; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }

        }
    }
}
