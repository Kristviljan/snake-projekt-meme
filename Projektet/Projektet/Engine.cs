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

            

            Application.Run(form);
            AddFood();
        }

        public void AddFood()
        {
            if(foods.Count < 2)
            {
                var food = new Food(20*random.Next(2, 30), 20*random.Next(2, 20), Food.Type.standard);
            }
        }
        private void TimerEventHandler(object sender, EventArgs e)
        {

        }
        private void Draw(Object obj, PaintEventArgs args)
        {
            form.snake.Head.Draw(args.Graphics);
            foreach(var Food in foods)
            {
                Food.Draw(args.Graphics);
            }
        }
    }
}

