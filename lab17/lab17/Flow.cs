using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace lab17
{
    class Flow
    {

        public float Time { get; set; } = 0;
        private float la;

        private Random rnd = new Random();
        public int Count { get; set; } = 0;

        public Flow(float La)
        {

            this.la = La;
            
        }

        public float Next()
        {
            var step = Time + (-((float)Math.Log(rnd.NextDouble() / la)));
            var delta = step - Time;
            Time = delta;
            return la * (float)Math.Pow(Math.E, (-la * delta));
        }
    }
}