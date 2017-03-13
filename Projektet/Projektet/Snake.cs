using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet
{
    public class Snake
    {
        ISet<Rectangle> bodies = new HashSet<Rectangle>();

        private Rectangle head = new Rectangle(400, 300);

        public void AddBody(int x, int y)
        {
            var Body = new Rectangle(x, y);
            bodies.Add(Body);
        }
        public void Move(int pressed)
        {

        }
        public Rectangle Head
        {
            get { return head; }
        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
