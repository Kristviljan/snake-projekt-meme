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
        }

        public void AddFood()
        {

        }
        private void TimerEventHandler(Object obj, EventArgs args)
        {

        }
        private void Draw(Object obj, PaintEventArgs args)
        {

        }
    }
}

