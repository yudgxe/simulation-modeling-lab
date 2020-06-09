using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        private Drawer drawer;
        private Model model;
        private Player player;
        private double currentPrice;
        private bool isPause = false;
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(chart1);
            model = new Model();
            player = new Player();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!(char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (tb.Text.IndexOf(",") == -1) && (tb.Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }

        }
        float currentDay;
        private void btRun_Click(object sender, EventArgs e)
        {
            currentDay = 0;
            model.price = currentPrice = Convert.ToDouble(inputPrice.Text);
            player.SetMoney(currentPrice * 1.1);
            UpdateLableMoney(player.money, 0);
            model.days = Convert.ToInt32(inputDays.Text);
            drawer.Start(currentDay++, model.price) ; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(currentDay > model.days)
            {
                timer1.Stop();
                return;
            }

            currentPrice = model.GetNewPrice();
            drawer.Draw(currentDay++, currentPrice); 
        }

        private void UpdateLableMoney(double money,int stocks)
        {
            lbPrice.Text = Math.Round(money,4).ToString() + "$";
            lbStocks.Text = stocks.ToString();
        }
        private void btBuy_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                player.Buy(currentPrice);
                UpdateLableMoney(player.money, player.countStocks);
            }
        }

        private void btSell_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                player.Sell(currentPrice);
                UpdateLableMoney(player.money, player.countStocks);
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isPause = true;
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if(isPause)
            {
                timer1.Start();
                isPause = false;
            }
        }
    }
    public class Model
    {
        double w = 0;
        const double dt = 0.001f, mu = 0.1d, xi = 0.01d;

        private Random rnd = new Random();
        public double price { get; set; }
        public int days { get; set; }

        private double getNum()
        {
            return Math.Sqrt(-2 * Math.Log(rnd.NextDouble())) * Math.Cos(2 * Math.PI * rnd.NextDouble());
        }
        public double GetNewPrice()
        {
            w += Math.Sqrt(dt) * getNum();
            price *= Math.Exp((mu - xi * xi * 0.5) * dt + xi * w);
            return price;
        }
    }

    public class Player
    {
        public double money { get; set; }
        public int countStocks { get; private set; } = 0;


        public void SetMoney(double startMoney)
        {
            money = startMoney;
        }


        public void Sell(double value)
        {
            if(countStocks > 0)
            {
                money += value;
                countStocks--;
            }
        }

        public void Buy(double value)
        {
            if (money - value >= 0)
            {
                money -= value;
                countStocks++;
            }
        }
    }
}
