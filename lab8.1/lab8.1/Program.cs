using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Transactions;

namespace lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string> { "Да", "Нет", "Может-быть", "Возможно", "Наверно" };
            Random rnd = new Random();
            double alfa, A, pi = 0.2;
            int k = 0;

            while (true)
            {
                Console.ReadLine();
                alfa = rnd.NextDouble();
                A = alfa - pi;

                for (k = 0; A > 0; k++, A -= pi) { }

                Console.WriteLine(answers[k]);
            }
        }
    }
}
