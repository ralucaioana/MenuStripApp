using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MenuStripApp
{
    enum TextFontSize
    {
        FontSizeHuge = 30,
        FontSizeNormal = 20,
        FontSizeTiny = 8
    }

    public partial class Form1 : Form
    {
        private TextFontSize currentFontSize = TextFontSize.FontSizeNormal;

        public Form1()
        {
            InitializeComponent();
            this.toolStripTextBoxColor.LostFocus += new EventHandler(toolStripTextBoxColor_LostFocus);
        }

        void toolStripTextBoxColor_LostFocus(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.FromName(toolStripTextBoxColor.Text);
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Right click on me....",
                new Font("Times New Roman", (float)currentFontSize),
                new SolidBrush(Color.Black),50,50);
        }

        private void hugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem miClicked = sender as ToolStripMenuItem;
            switch (miClicked.Name)
            {
                case "hugeToolStripMenuItem":
                    currentFontSize = TextFontSize.FontSizeHuge;
                    break;
                case "huToolStripMenuItem":
                    currentFontSize = TextFontSize.FontSizeHuge;
                    break;
                
            }
        }
    }
}