using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet
{
    public class Snake
    {
        List<Rectangle> bodies = new List<Rectangle>();
        private Rectangle head;

        private int speed;

        public Snake(int x, int y)
        {
            head = new Rectangle(x, y);
        }

        public void AddBody()
        {
            Rectangle Body = new Rectangle(bodies[bodies.Count - 1].Position.X, bodies[bodies.Count - 1].Position.Y);
            bodies.Add(Body);
        }
        public void Move(int pressed)
        {
            this.Head.Position.X = 1
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
