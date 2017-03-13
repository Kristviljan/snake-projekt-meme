using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet
{
    class Snake
    {
        ISet<Snake> bodies = new HashSet<Snake>();

        public void AddBody()
        {
            var Body = new Snake();
            bodies.Add(Body);
        }
        public void Move(int pressed)
        {

        }
    }
}
