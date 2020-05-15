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
        Density pl;

        int[] statistic = new int[8];

        double A, Sum, kvadraA, Chi, a;
        decimal[] Freq = new decimal[8];
        decimal MT, M, MErr, DT, D, DErr;

        int k = -4;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            M = 0; D = 0; Chi = 0; Sum = 0; kvadraA = 0; a = -3.5;

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 8; i++)
            {
                statistic[i] = 0;
            }

            MT = Mean.Value;
            DT = Var.Value;

            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "firstBtn":
                    method = new FirstMethod(MT, DT);
                    break;
                case "secondBtn":
                    method = new SecondMethod(MT, DT);
                    break;
                case "thirdBtn":
                    method = new ThirdMethod(MT, DT);
                    break;

                default:
                    return;
            }
            pl = new Density(MT, DT);

            for (int i = 0; i < NumExp.Value; i++)
            {
                A = method.getNum();
                Sum = Sum + A;
                kvadraA = kvadraA + A * A;
                k = -4;
                for (int j = 0; j < 8; j++)
                {
                    if (A < k + 1 && A > k)
                    {
                        statistic[j]++;
                        break;
                    }
                    k++;
                }
            }

            for (int j = 0; j < 8; j++)
            {
                Freq[j] = statistic[j] / NumExp.Value;
                chart1.Series[0].Points.AddXY(j, Freq[j]);
            }

            M = (decimal)Sum / NumExp.Value;
            D = (decimal)kvadraA / NumExp.Value - M * M;

            chiCounter();
            errorCounter();
            writer();

        }
      
        void writer()
        {
            AverageLbl.Text = "Average: " + M + " (error = " + Math.Round(MErr * 100, 5) + "%)";
            VarianceLbl.Text = "Variance: " + D + " (error = " + Math.Round(DErr * 100, 5) + "%)";
            if (Chi > 15.507)
            {
                Chi1Lbl.Text = "Chi-squared: " + Chi + " > 15.507 is true";
            }
            else { Chi1Lbl.Text = "Chi-squared: " + Chi + " > 15.507 is false"; }
        }

        void errorCounter()
        {
            MErr = MT != 0 ? Math.Abs(M - MT) / MT : default;
            DErr = DT != 0 ? Math.Abs(D - DT) / DT : default;
        }

        void chiCounter()
        {
            for (int j = 0; j < 8; j++)
            {

                Chi = Chi + ((statistic[j] * statistic[j]) / ((double)NumExp.Value * pl.getP(a)));
                a++;
            }
            Chi = Chi - (double)NumExp.Value;
        }
    }
}
