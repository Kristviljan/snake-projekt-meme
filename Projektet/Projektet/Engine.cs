using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Projektet
{
    public class Engine
    {
        private Timer timer;
        private Form1 form;

        private ISet<Snake> snakes = new HashSet<Snake>();
        private ISet<Food> foods = new HashSet<Food>();

        public Snake snake = new Snake(400,300);

        private Random random = new Random();

        public Engine()
        {
            form = new Form1();
            timer = new Timer();
        }
        public void Run()
        {
            
            form.Paint += new PaintEventHandler(Draw);

            
            timer.Interval = 1000 / 60;
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Start();

            form.KeyDown += new KeyEventHandler(keyeventhandler);

            Application.Run(form);
            
        }

        public void keyeventhandler(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                snake.dir = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                snake.dir = 1;
            }
            else if (e.KeyCode == Keys.S)
            {
                snake.dir = 2;
            }
            else if (e.KeyCode == Keys.D)
            {
                snake.dir = 3;
            }
        }

        public void AddFood()
        {
            if(foods.Count < 2)
            {
                var food = new Food(20*random.Next(2, 30), 20*random.Next(2, 20), Food.Types.standard);
                foods.Add(food);
            }
        }

        void Collision(Snake snek1, Snake snek2)
        {
            foreach(Rectangle Body in snek2.bodies)
            {
                if (snek1.Head.Position.X + 10 >= Body.Position.X && snek1.Head.Position.X <= Body.Position.X + 10 &&
                    snek1.Head.Position.Y + 10 >= Body.Position.Y && snek1.Head.Position.Y <= Body.Position.X + 10)
                {
                    // INSERT LOOSE SHIT HERE
                }
            }
        }
        private void TimerEventHandler(object sender, EventArgs e)
        {
            AddFood();
            //form.snake.Move();
            form.Refresh();
        }
        private void Draw(Object obj, PaintEventArgs args)
        {
            //form.snake.Head.Draw(args.Graphics);
            foreach(var Body in snake.bodies)
            {
                Body.Draw(args.Graphics);
            }
            //Food fod = new Food(50,50,Food.Type.standard );
            //fod.Draw(args.Graphics);
            foreach(var food in foods)
            {
                food.Draw(args.Graphics);
            }
        }
    }
}
