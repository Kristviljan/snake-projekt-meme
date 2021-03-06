﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektet
{
    public class Snake
    {
        public List<Rectangle> bodies = new List<Rectangle>();
        private Rectangle head;
        public int dir = 0;
        private int i;
        private int speed = 5;
        public int points = 0;

        private Timer snakeTimer;
        

        public Snake(int x, int y, int z)
        {
            head = new Rectangle(x, y);
            if (z == 1)
                head.brush.Color = System.Drawing.Color.Black;
            else
                head.brush.Color = System.Drawing.Color.DodgerBlue;
            bodies.Add(head);
            snakeTimer = new Timer();
            snakeTimer.Interval = 1000 / speed;
            snakeTimer.Tick += new EventHandler(Move);
            snakeTimer.Start();
            AddBody();
            AddBody();
        }

        public void AddBody()
        {
            Rectangle Body = new Rectangle(bodies[bodies.Count - 1].Position.X, bodies[bodies.Count - 1].Position.Y);
            Body.brush.Color = head.brush.Color;
            bodies.Add(Body);
        }
        public void RemoveBody()
        {
            if (bodies.Count > 3)
                bodies.Remove(bodies[bodies.Count - 1]);
        }
        private void Move(object sender, EventArgs e)
        {
            snakeTimer.Interval = 1000 / speed;
            for(i=bodies.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (dir)
                    {
                        case 0:
                            if (bodies[i].Position.Y - 10 < -10)
                                bodies[i].Position.Y = 600;
                            else
                                bodies[i].Position.Y = bodies[i].Position.Y - 10;
                            break;
                        case 1:
                            if (bodies[i].Position.X - 10 < -10)
                                bodies[i].Position.X = 800;
                            else
                                bodies[i].Position.X = bodies[i].Position.X - 10;
                            break;
                        case 2:
                            if (bodies[i].Position.Y + 10 > 600)
                                bodies[i].Position.Y = -10;
                            else
                                bodies[i].Position.Y = bodies[i].Position.Y + 10;
                            break;
                        case 3:
                            if (bodies[i].Position.X + 10 > 800)
                                bodies[i].Position.X = -10;
                            else
                                bodies[i].Position.X = bodies[i].Position.X + 10;
                            break;
                    }
                }

                else
                {
                    bodies[i].Position.X = bodies[i - 1].Position.X;
                    bodies[i].Position.Y = bodies[i - 1].Position.Y;
                }
            }
        }
        public Rectangle Head
        {
            get { return head; }
        }
        
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
