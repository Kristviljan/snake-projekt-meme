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
        private int type;

        public Food (int x, int y, int type) : base(x,y)
        {
            this.type = type;
            Colour();
        }
        private void Colour()
        {
            if (this.type >= 0 && this.type <= 33)
            {
                this.brush.Color = Color.Green;
            }
            else if (this.type > 33 && this.type <= 66)
            {
                this.brush.Color = Color.Gold;
            }
            else if (this.type > 66 && this.type <= 99)
            {
                this.brush.Color = Color.DarkRed;
            }
            else if (this.type > 99 && this.type <= 132)
            {
                this.brush.Color = Color.Blue;
            }
        }
        public void Eat(Snake snek)
        {
            if (this.type >= 0 && this.type <= 33)
            {
                snek.points++;
            }
            else if (this.type > 33 && this.type <= 66)
            {
                snek.points += 5;
            }
            else if (this.type > 66 && this.type <= 99)
            {
                snek.Speed += 5;
            }
            else if (this.type > 99 && this.type <= 132)
            {
                snek.Speed -= 5;
            }
        }
        /*override public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, point.X, point.Y, 50, 50);
        }*/
    }
}
