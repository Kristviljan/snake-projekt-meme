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
            else if (this.type > 132 && this.type <= 165)
            {
                this.brush.Color = Color.HotPink;
            }
        }
        public void Eat(Snake snek)
        {
            if (this.type >= 0 && this.type <= 33)
            {
                snek.Speed += 1;
                snek.points++;
                snek.AddBody();
            }
            else if (this.type > 33 && this.type <= 66)
            {
                snek.Speed += 1;
                snek.points += 5;
                snek.AddBody();
            }
            else if (this.type > 66 && this.type <= 99)
            {
                if (snek.Speed >= 55)
                    snek.Speed = 60;
                else
                    snek.Speed += 5;
                snek.AddBody();
                snek.points++;
            }
            else if (this.type > 99 && this.type <= 132)
            {
                if (snek.Speed <= 10)
                    snek.Speed = 5;
                else
                    snek.Speed -= 5;
                snek.AddBody();
                snek.points++;
            }
            else if (this.type > 132 && this.type <= 165)
            {
                snek.RemoveBody();
                snek.points++;
            }
        }
        /*override public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, point.X, point.Y, 50, 50);
        }*/
    }
}
