﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projektet
{
    public class Rectangle
    {
        public Pen pen = new Pen(Color.Black);
        private Point point = new Point();

        public Rectangle(int x, int y)
        {
            this.point.X = x;
            this.point.Y = y;
        }
        // public abstract void Draw(Graphics g);
        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, Point.X, Point.Y, 50, 50);
        }
        public Point Point
        {
            get { return point; }
            set { point = value; }
        }
    }
}