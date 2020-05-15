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

namespace imit13
{
    public partial class Form1 : Form
    {
        Random rnd;
        List<float> values = new List<float>();
        float p;
        int[] Count;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Initialize();

            if (check())
            {
                StatPanel.Visible = true;
                getRndValue();
                counter();
                
                for (int i = 0; i < 4; i++)
                {
                    chart1.Series[0].Points.AddXY(i, Count[i] / numericUpDown1.Value);
                    Count[i] = 0;
                }
            }
            

        }
        bool check()
        {
            var SumToCheck = 0f;
            foreach (var value in values)
            {
                SumToCheck += (float)value;
            }

            return SumToCheck == 1f ? true : false;
        }

        void Initialize()
        {
            chart1.Visible = true;
            chart1.Series[0].Points.Clear();
            values.Clear();
            float Sum = 0;
            
            p = float.Parse(textBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
            for (int i = 0; i < 3; i++)
            {
                values.Add(p*(float)Math.Pow((1-p),i));
                Sum += values[i];
            }
            values.Add(1 - Sum);
            Count = new int[4];
        }

        void getRndValue()
        {
            double A = 0;
            int k = 0;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                A = rnd.NextDouble();
                k = 0;
                foreach (var value in values)
                {
                    A -= value;
                    if (A <= 0)
                    {
                        Count[k]++;
                        break;
                    }
                    k++;
                }
            }
        }

        void counter()
        {
            float chi = 9.488f;

            float M = 0, D = 0, Derror = 0, Merror = 0, Chi_square = 0;
            for (int i = 0; i < 4; i++)
            {
                M += (Count[i] / (float)numericUpDown1.Value) * (i + 1);
                Merror += values[i] * (i + 1);

                D += (Count[i] / (float)numericUpDown1.Value) * (i + 1) * (i + 1);
                Derror += values[i] * (i + 1) * (i + 1);

                Chi_square += ((Count[i] * Count[i]) / ((float)numericUpDown1.Value * (float)values[i]));
            }

            Chi_square -= (float)numericUpDown1.Value;
            D -= M * M;
            Derror -= Merror * Merror;

            VarianceLbl.Text = D.ToString();
            AverageLbl.Text = M.ToString();

            ErrAvgLbl.Text = (Math.Abs(M - Merror) / Math.Abs(Merror)).ToString();
            ErrVarLbl.Text = (Math.Abs(D - Derror) / Math.Abs(Derror)).ToString();
            Chi1Lbl.Text = Chi_square.ToString();
            Chi2Lbl.Text = chi.ToString();

            BoolLbl.Text = Chi_square > chi ? "true" : "false";
        }
    }
}
