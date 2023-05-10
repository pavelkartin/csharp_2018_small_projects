using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //jen a (maly)
            //text.toLower

            clearSelection();

            string[] words = txtSearch.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < richTextBox.TextLength)
                {
                    int wordStartIndex = richTextBox.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        richTextBox.SelectionStart = wordStartIndex;
                        richTextBox.SelectionLength = word.Length;
                        richTextBox.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startIndex = wordStartIndex + word.Length;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            clearSelection();
        }

        private void clearSelection()
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
        }
    }
}
