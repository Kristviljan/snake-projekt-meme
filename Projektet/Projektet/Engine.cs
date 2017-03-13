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

        private Random random = new Random();

        public Engine()
        {
            form = new Form1();
            timer = new Timer();
        }
        public void Run()
        {
            form.Paint += new PaintEventHandler(Draw);
            
            

            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / 60;
            timer.Start();


            Application.Run(form);
            AddFood();
        }

        public void AddFood()
        {
            if(foods.Count < 2)
            {
                var food = new Food(random.Next(50, 410), random.Next(50, 310), Food.Type.standard);
            }
        }
        private void TimerEventHandler(Object obj, EventArgs args)
        {

        }
        private void Draw(Object obj, PaintEventArgs args)
        {
            Rectangle rect = new Rectangle(1, 1);
            rect.Draw(args.Graphics);
            foreach(var Food in foods)
            {
                Food.Draw(args.Graphics);
            }
        }
    }
}

