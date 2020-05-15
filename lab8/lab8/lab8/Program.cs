using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ReadLine();
                double alfa = 0.5;
                Random rnd = new Random();
                string answer = rnd.NextDouble() < 0.5 ? "Yes" : "No";
                Console.WriteLine(answer);
            }
        }
    }
}
