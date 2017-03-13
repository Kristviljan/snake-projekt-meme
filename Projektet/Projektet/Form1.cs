using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektet
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush = new SolidBrush(Color.Black);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(flowLayoutPanel1_Paint_KeyDown);
            g = flowLayoutPanel1.CreateGraphics();
            g.FillRectangle(brush, 40, 40, 40, 40);

            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void flowLayoutPanel1_Paint_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Console.WriteLine("w");
            }
            else if (e.KeyCode == Keys.A)
            {
                Console.WriteLine("a");
            }
            else if (e.KeyCode == Keys.S)
            {
                Console.WriteLine("s");
            }
            else if (e.KeyCode == Keys.D)
            {
                Console.WriteLine("d");
            }
        }
    }
}
