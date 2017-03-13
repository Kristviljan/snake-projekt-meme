using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet
{
    public class Snake
    {
        List<BodyRectangle> bodies = new List<BodyRectangle>();
        private Rectangle head;

        private int speed;

        public Snake(int x, int y)
        {
            head = new Rectangle(x, y);
        }

        public void AddBody()
        {
            BodyRectangle Body;
            if (bodies[bodies.Count - 1].MoveDirection == BodyRectangle.Direction.right)
            {
                Body = new BodyRectangle(bodies[bodies.Count - 1].Point.X - 10, bodies[bodies.Count - 1].Point.Y, BodyRectangle.Direction.right);
                bodies.Add(Body);
            }
            else if (bodies[bodies.Count - 1].MoveDirection == BodyRectangle.Direction.left)
            {
                Body = new BodyRectangle(bodies[bodies.Count - 1].Point.X + 10, bodies[bodies.Count - 1].Point.Y, BodyRectangle.Direction.left);
                bodies.Add(Body);
            }
            else if (bodies[bodies.Count - 1].MoveDirection == BodyRectangle.Direction.up)
            {
                Body = new BodyRectangle(bodies[bodies.Count - 1].Point.X, bodies[bodies.Count - 1].Point.Y - 10, BodyRectangle.Direction.up);
                bodies.Add(Body);
            }
            else if (bodies[bodies.Count - 1].MoveDirection == BodyRectangle.Direction.down)
            {
                Body = new BodyRectangle(bodies[bodies.Count - 1].Point.X, bodies[bodies.Count - 1].Point.Y + 10, BodyRectangle.Direction.down);
                bodies.Add(Body);
            }
            
        }
        public void Move(int pressed)
        {

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
