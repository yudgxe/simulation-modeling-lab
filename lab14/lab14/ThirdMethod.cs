using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class ThirdMethod : Method
    {

        public ThirdMethod(decimal mean, decimal var) : base(mean, var) { }
        public override double getNum()
        {
            double a1 = rnd.NextDouble();
            double a2 = rnd.NextDouble();
            double sum = Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * 3.14 * a2);
            return Math.Sqrt((double)var) * sum + (double)mean;
        }
    }
}
