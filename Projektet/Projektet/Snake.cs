using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet
{
    class Snake
    {
        ISet<Rectangle> bodies = new HashSet<Rectangle>();

        public void AddBody()
        {
            var Body = new Rectangle(50, 50);
            bodies.Add(Body);
        }
        public void Move(int pressed)
        {

        }
    }
}
