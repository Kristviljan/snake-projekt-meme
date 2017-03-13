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

        public void AddBody(int x, int y)
        {
            var Body = new Rectangle(x, y);
            bodies.Add(Body);
        }
        public void Move(int pressed)
        {

        }
    }
}
