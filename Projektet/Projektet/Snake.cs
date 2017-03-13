using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet
{
    public class Snake
    {
        //ISet<Rectangle> bodies = new HashSet<Rectangle>();
        List<Rectangle> bodies = new List<Rectangle>();
        private Rectangle head;
        public Snake(int x, int y)
        {
            head = new Rectangle(x, y);
        }

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
