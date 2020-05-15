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

namespace ManyEventsDiscreth
{
    public partial class Form1 : Form
    {
        
        Random rnd;
        List<float> values = new List<float>();
        int[] Count = new int[5] { 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            rnd = new Random(); 
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            
            init();
            double sum = 0;

            foreach (var value in values)
                sum += value;

            if ((int)sum == 1)
            {
                StatPanel.Visible = true;
                double A = 0;
                int k = 0;
                float M = 0, D = 0, Derror = 0, Merror = 0, Chi_square = 0;
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

                for (int i = 1; i < 6; i++) 
                {
                    chart1.Series[0].Points.AddXY(i, Count[i - 1]/ numericUpDown1.Value);
                }

                for (int i = 0; i < 5; i++)
                {
                    M += (Count[i] / (float)numericUpDown1.Value) * (i + 1);
                    Merror += values[i] * (i + 1);


                    D += (Count[i] / (float)numericUpDown1.Value) * (i + 1) * (i + 1);
                    Derror = values[i] * (i + 1) * (i + 1);

                    Chi_square += ((Count[i] * Count[i]) / ((float)numericUpDown1.Value * values[i]));
                }
                Chi_square -= (float)numericUpDown1.Value;

                D -= M * M;
                Derror -= Merror * Merror;

                VarianceLbl.Text = D.ToString();
                AverageLbl.Text = M.ToString();

                ErrAvgLbl.Text = (Math.Abs((M - Merror) / Math.Abs(Merror))).ToString();
                ErrVarLbl.Text = (Math.Abs((D - Derror) / Math.Abs(Derror))).ToString();

                Chi1Lbl.Text = Chi_square.ToString();
                Chi2Lbl.Text = "11.070";

                for (int i = 0; i < 5; i++)
                {
                    Count[i] = 0;
                }

                BoolLbl.Text = Chi_square >= 11.070 ? "true" : "false";
            }
        }


        void init()
        {
            chart1.Series[0].Points.Clear();
            values.Clear();
            try
            {
                values.Add(float.Parse(textBox1.Text, CultureInfo.InvariantCulture.NumberFormat));
                values.Add(float.Parse(textBox2.Text, CultureInfo.InvariantCulture.NumberFormat));
                values.Add(float.Parse(textBox3.Text, CultureInfo.InvariantCulture.NumberFormat));
                values.Add(float.Parse(textBox4.Text, CultureInfo.InvariantCulture.NumberFormat));
                values.Add(float.Parse(textBox5.Text, CultureInfo.InvariantCulture.NumberFormat));
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
