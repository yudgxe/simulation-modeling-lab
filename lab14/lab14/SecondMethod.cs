using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class SecondMethod : Method
    {
        public SecondMethod(decimal mean, decimal var) : base(mean, var) { }
        public override double getNum()
        {
            double sum = default;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + rnd.NextDouble();
            }
            sum = sum - 6;
            sum = sum + ((1 / 240) * ((sum * sum * sum) - (3 * sum)));
            return Math.Sqrt((double)var) * sum + (double)mean;
        }
    }
}
