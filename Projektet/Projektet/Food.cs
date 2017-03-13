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
        public enum Types { standard, bonus, speed, slow }

        public Food (int x, int y, Types types) : base(x,y)
        {
            if ((int)types == 1)
            {

            }
            else if ((int)types == 2)
            {

            }
            else if ((int)types == 3)
            {

            }
            else if ((int)types == 4)
            {

            }
        }
        /*override public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, point.X, point.Y, 50, 50);
        }*/
    }
}
