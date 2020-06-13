using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace lab17
{
    public partial class Form1 : Form
    {
        int exps;
        List<int> freqA;
        List<int> freqB;

        int[] T = new int[3];
        int[] N = new int[3];
        List<Flow> flows = new List<Flow>(3);
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flows.Clear();

            exps = Int32.Parse(textBox5.Text, CultureInfo.InvariantCulture.NumberFormat);
            N[0] = Int32.Parse(textBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
            T[0] = Int32.Parse(textBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
            N[1] = Int32.Parse(textBox3.Text, CultureInfo.InvariantCulture.NumberFormat);
            T[1] = Int32.Parse(textBox4.Text, CultureInfo.InvariantCulture.NumberFormat);
            
            N[2] = Math.Max(N[0], N[1]);
            T[2] = Math.Max(T[0], T[1]);
            freqA = new List<int>(new int[T[2]]);
            freqB = new List<int>(new int[T[2]]);


            flows.Add(new Flow((float)N[0] / (float)T[0]));
            flows.Add(new Flow((float)N[1] / (float)T[1]));
            flows.Add(new Flow((float)N[0] / (float)T[0] + (float)N[1] / (float)T[1]));

            if (N[0] > T[0] || N[1] > T[1]) 
            {
                MessageBox.Show("N > T", "Error");
            }
            else
            {
                StartCalc();
            } 
        }

        void StartCalc()
        {
            for (int i = 0; i < exps; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    var temp = flows[j].Next();
                    if(flows[j].Count < N[j] && flows[j].Time < T[j])
                    {
                        if(j == 2)
                            freqB[(int)flows[j].Time]++;
                        else 
                            freqA[(int)flows[j].Time]++;
                        flows[j].Count++;
                    } 
                }

            }


            foreach (var item in chart1.Series)
            {
                item.Points.Clear();
            }

            for (int i = 0; i < freqA.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i, (float)freqA[i] / (float)T[2]);
                chart1.Series[1].Points.AddXY(i, (float)freqB[i] / (float)T[2]);
            }


        }
    }
}
