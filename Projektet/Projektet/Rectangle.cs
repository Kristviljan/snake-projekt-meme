using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projektet
{
    public class Rectangle
    {
        public SolidBrush brush = new SolidBrush(Color.Black);
        public Point Position = new Point();
        

        public Rectangle(int x, int y)
        {
            this.Position.X = x;
            this.Position.Y = y;
        }
        // public abstract void Draw(Graphics g);
        public void Draw(Graphics g)
        {
            g.FillRectangle(brush, Position.X + 12 , Position.Y + 12, 10, 10);
        }
    }
}