using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projektet
{
    public class Food : Rectangle
    {
        public enum Type { standard, bonus, speed }

        public Food (int x, int y, Type type) : base(x,y)
        {
        }
        /*override public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, point.X, point.Y, 50, 50);
        }*/
    }
}
