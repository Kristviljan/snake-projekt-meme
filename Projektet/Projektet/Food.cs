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
        Types type;

        public Food (int x, int y, Types types) : base(x,y)
        {
            this.type = types;
            Colour();
        }
        private void Colour()
        {
            if ((int)this.type == 0)
            {
                this.brush.Color = Color.Green;
            }
            else if ((int)type == 1)
            {
                this.brush.Color = Color.Gold;
            }
            else if ((int)type == 2)
            {
                this.brush.Color = Color.DarkRed;
            }
            else if ((int)type == 3)
            {
                this.brush.Color = Color.Blue;
            }
        }
        public void Eat(Snake snek)
        {
            if ((int)this.type == 1)
            {

            }
            else if ((int)type == 2)
            {

            }
            else if ((int)type == 3)
            {
                snek.Speed += 5;
            }
            else if ((int)type == 4)
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
