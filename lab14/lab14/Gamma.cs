using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class Gamma : Method
    { 
        public override double getNum()
        {
            const double e = 2.718;
            double k = rnd.NextDouble();
            double Density = e / (e + k), a = 1 / k, alfa_1, alfa_2, beta, teta;
            double d = Density / (1 - Density);
            do
            {
                alfa_1 = rnd.NextDouble();
                alfa_2 = rnd.NextDouble();
                beta = alfa_1 / Density;
                teta = beta < 1 ? beta * a : (float)(-Math.Log(d * (beta - 1)));

            } while (teta < 1 && Math.Exp(-teta) < alfa_2 || teta >= 1 && teta * (k - 1) < alfa_2);
            return teta;
        }
    }
}
