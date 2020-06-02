using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imit14
{
    public partial class Form1 : Form
    {
        Method method;
   
        int[] statistic = new int[8];

        double A, sum, kA, Chi, a;
        decimal[] Freq = new decimal[8];
        decimal M, D;

        float k = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            M = 0; D = 0; Chi = 0; sum = 0; kA = 0; a = -3.5;

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 8; i++)
            {
                statistic[i] = 0;
            }

            method = new Gamma();

            for (int i = 0; i < NumExp.Value; i++)
            {
                A = method.getNum();
                sum = sum + A;
                kA = kA + A * A;
                k = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (A < k + 0.2 && A > k)
                    {
                        statistic[j]++;
                        break;
                    }
                    k += 0.125f;
                }
            }

            float w = 0;
            for (int j = 0; j < 8; j++)
            {
                Freq[j] = statistic[j] / NumExp.Value;
                chart1.Series[0].Points.AddXY(j, Freq[j]);
                w += 0.2f;
            }

            M = (decimal)sum / NumExp.Value;
            D = (decimal)kA / NumExp.Value - M * M;

            writer();

        }

        void writer()
        {
            AverageLbl.Text = "Average: " + M;
            VarianceLbl.Text = "Variance: " + D;
        }
    }
}
