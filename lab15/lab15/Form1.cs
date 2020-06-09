using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15
{

    public enum State {
        Morning,
        Day,
        Evening
    }

    public enum Weather {
        Sunny,
        Cloudy,
        Rain
    }

    public partial class Form1 : Form
    {
        private float[,] P = {
            { 0.3f, 0.4f, 0.3f },
            { 0.2f, 0.6f, 0.2f },
            { 0.1f, 0.4f, 0.5f }
        };

        private State state = State.Morning;
        private int dayCount = 0;

        private string[] states = { "Morning", "Day", "Evening" };
        private string[] weathers = { "Sunny", "Cloudy", "Rain" };

        private List<float> values = new List<float>();
        private List<int> freq = new List<int> { 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            else 
            {
                timer1.Stop();
            }
        }

        private void CalcMat(int state)
        {
            values.Clear();
            for (int i = 0; i < 3; i++)
            {
                values.Add(P[state, i]);
            }
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == State.Morning)
            {
                DayCountLab.Text = (++dayCount).ToString();
            }

            CalcMat((int)state);
            int weather = getRnd();
            freq[weather]++;

            StateLab.Text = states[(int)state];
            WeatherLab.Text = weathers[weather];

            SunnyLab.Text = ((float)(freq[0] / (float)dayCount)).ToString();
            CloudyLab.Text = ((float)(freq[1] / (float)dayCount)).ToString();
            RainLab.Text = ((float)(freq[2] / (float)dayCount)).ToString();

            state = state == State.Evening ? State.Morning : state += 1;  
        }


        private int getRnd()
        {
            Random rnd = new Random();
            double A = rnd.NextDouble();
            int k = 0;
          
            foreach(var value in values)
            {
                A -= value;
                if (A <= 0) break;
                k++;
            }

            return k;
        }
    }
}
