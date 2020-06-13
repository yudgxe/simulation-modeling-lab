using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace imit18
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Input windows count: ");
            int windowsCount = Int32.Parse(Console.ReadLine());
            Console.Write("Input Agents count: ");
            int agentsCount = Int32.Parse(Console.ReadLine());
            Console.Write("Input experiments count: ");
            int numbOfExp = Int32.Parse(Console.ReadLine());

            lab18 lab = new lab18(windowsCount, agentsCount, numbOfExp);
            lab.Start();


            Console.ReadLine();
        }
    }
}