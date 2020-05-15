using System;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] facets = new double[6] { 0.1, 0.1, 0.1, 0.1, 0.1, 0.5 };
            Random rnd = new Random();

            while (true)
            {
                double alfa = rnd.NextDouble(), A = alfa;
                int k = 0;
                do
                {
                    A -= facets[k];
                    k++;
                } while (A > 0);

                Console.WriteLine(k);
            }
        }
    }
}
