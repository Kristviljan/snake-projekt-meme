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

        public Snake snake = new Snake(400, 300, 1);
        public Snake snake2 = new Snake(300, 400, 2);


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

            form.KeyDown += new KeyEventHandler(Player1Handler);
            form.KeyDown += new KeyEventHandler(Player2Handler);

            Application.Run(form);

        }

        public void Player1Handler(object sender, System.Windows.Forms.KeyEventArgs e)
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
        public void Player2Handler(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && snake2.dir != 2)
            {
                snake2.dir = 0;
            }
            else if (e.KeyCode == Keys.Left && snake2.dir != 3)
            {
                snake2.dir = 1;
            }
            else if (e.KeyCode == Keys.Down && snake2.dir != 0)
            {
                snake2.dir = 2;
            }
            else if (e.KeyCode == Keys.Right && snake2.dir != 1)
            {
                snake2.dir = 3;
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

        void Collision(Snake snake, Snake snake2) // Snake snek2)
        {
            foreach(var Body in snake2.bodies)
            {
                if (snake.Head.Position == Body.Position)
                {
                    snake.points -= 10;
                    snake2.points += 10;
                    End();
                    break;
                    //INSERT LOOSE SHIT HERE
                }
                
                if (snake2.Head.Position == Body.Position)
                {
                    if (snake2.Head.Position == Body.Position)
                    {
                        if (!Body.Equals(snake2.Head) && snake2.bodies.Count > 3)
                        {
                            snake2.points -= 5;
                            End();// snek2 collides with itself
                            break;
                        }
                    }// snek2 collides with itself
                }
            }
            foreach(var Body in snake.bodies)
            {
                if (snake2.Head.Position == Body.Position)
                {
                    snake2.points -= 10;
                    snake.points += 10;
                    End();
                    break;
                    // PLAYER 2 HIT PLAYER 1
                }
                if (snake.Head.Position == Body.Position)
                {
                    if (!Body.Equals(snake.Head) && snake.bodies.Count > 3)
                    {
                        snake.points -= 5;
                        End();// snek1 collides with itself
                        break;
                    }
                }
            }
            foreach(var food in foods)
            {
                if (snake2.Head.Position == food.Position)
                {
                    food.Eat(snake2);
                    foods.Remove(food);
                    //End();
                    break;
                }
                if (this.snake.Head.Position == food.Position)
                {
                    //this.snake.score++;
                    
                    food.Eat(snake);
                    foods.Remove(food);
                    //End();
                    break;
                }
            }
        }
        private void TimerEventHandler(object sender, EventArgs e)
        {
            AddFood();
            //form.snake.Move();
            
            form.Refresh();
            Collision(snake,snake2);
        }
        private void Draw(Object obj, PaintEventArgs args)
        {
            //form.snake.Head.Draw(args.Graphics);


            form.Scores(obj, args, snake.points, snake2.points);


            foreach (var Body in snake.bodies)
            {
                Body.Draw(args.Graphics);
            }
            foreach (var Body in snake2.bodies)
            {
                Body.Draw(args.Graphics);
            }
            //Food fod = new Food(50,50,Food.Type.standard );
            //fod.Draw(args.Graphics);
            foreach (var food in foods)
            {
                food.Draw(args.Graphics);
            }
        }
        private void End()
        {
            foods.Clear();
            snake.bodies.Clear();
            snake2.bodies.Clear();
            timer.Stop();
            form.Refresh();
            form.BackColor = System.Drawing.Color.Black;

            form.End(snake.points, snake2.points);

        }
    }
}
