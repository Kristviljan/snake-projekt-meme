using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projektet
{
    class Rectangle
    {
        private Pen pen = new Pen(Color.Black);
        private Point point = new Point();

        public Rectangle(int x, int y)
        {
            this.point.X = x;
            this.point.Y = y;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, Point.X, Point.Y, 50, 50);
        }
        Point Point
        {
            get { return point; }
            set { point = value; }
        }
    }
}
