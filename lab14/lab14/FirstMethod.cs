using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class FirstMethod : Method
    {
        public FirstMethod(decimal mean, decimal var) : base(mean, var) { }
        public override double getNum()
        {
            double sum = default;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + rnd.NextDouble();
            }
            sum = sum - 6;
            return Math.Sqrt((double)var) * sum + (double)mean;
        }
    }
}
