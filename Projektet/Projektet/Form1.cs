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
        public Snake snake = new Snake(400, 300);


        public Form1()
        {
            InitializeComponent();
        }

        private void Update(object sender, System.EventArgs e)
        {

            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(flowLayoutPanel1_Paint_KeyDown);

            g = flowLayoutPanel1.CreateGraphics();
            g.FillRectangle(brush, 0, 0, 10, 10);

            flowLayoutPanel1.Invalidate();
        }

        private void UpdateScore(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void flowLayoutPanel1_Paint_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                snake.dir = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                snake.dir = 1;
            }
            else if (e.KeyCode == Keys.S)
            {
                snake.dir = 2;
            }
            else if (e.KeyCode == Keys.D)
            {
                snake.dir = 3;
            }
        }
    }
}
