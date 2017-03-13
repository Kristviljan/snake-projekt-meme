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

        public Snake snake = new Snake(200, 300);
        public Snake snek2 = new Snake(600, 300);

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
            if (e.KeyCode == Keys.W && snake.dir != 2)
            {
                snake.dir = 0;
            }
            else if (e.KeyCode == Keys.A && snake.dir != 3)
            {
                snake.dir = 1;
            }
            else if (e.KeyCode == Keys.S && snake.dir != 0)
            {
                snake.dir = 2;
            }
            else if (e.KeyCode == Keys.D && snake.dir != 1)
            {
                snake.dir = 3;
            }
        }

        public void AddFood()
        {
            if (foods.Count < 5)
            {
                var food = new Food(20 * random.Next(2, 30), 20 * random.Next(2, 20), random.Next(0, 165));
                foods.Add(food);
            }
        }

        void Collision(Snake snake) // Snake snek2)
        {
            foreach(Rectangle Body in snek2.bodies)
            {
                if (snek2.Head.Position == Body.Position)
                {
                    if (!Body.Equals(snek2.Head) && snek2.bodies.Count > 3)
                    {
                        End();
                        break;
                    }
                }
                
                //if (snek2.Head.Position == Body.Position)
                {
                    // snek2 collides with itself
                }
            }
            foreach(var Body in snake.bodies)
            {
                if (snek2.Head.Position == Body.Position)
                {
                    End();
                    break;
                }
                if (snake.Head.Position == Body.Position)
                {
                    if (!Body.Equals(snake.Head) && snake.bodies.Count > 3)
                    {
                        End(); // snake collides with itself
                        break;
                    }
                }
            }
            foreach(var food in foods)
            {
                if (snek2.Head.Position == food.Position)
                {
                    food.Eat(snek2);
                    foods.Remove(food);
                    break;
                }
                if (this.snake.Head.Position == food.Position)
                {
                    food.Eat(snake);
                    foods.Remove(food);
                    break;
                }
            }
        }
        private void TimerEventHandler(object sender, EventArgs e)
        {
            AddFood();
            //form.snake.Move();
            form.Refresh();
            Collision(snake);
        }
        private void Draw(Object obj, PaintEventArgs args)
        {
            //form.snake.Head.Draw(args.Graphics);
            foreach(var Body in snake.bodies)
            {
                Body.Draw(args.Graphics);
            }
            foreach(var Body in snek2.bodies)
            {
                Body.Draw(args.Graphics)
            }
            //Food fod = new Food(50,50,Food.Type.standard );
            //fod.Draw(args.Graphics);
            foreach(var food in foods)
            {
                food.Draw(args.Graphics);
            }
        }
        private void End()
        {
            foods.Clear();
            snake.bodies.Clear();
            timer.Stop();
            form.Refresh();
            form.BackColor = System.Drawing.Color.Black;
        }
    }
}
