using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    public abstract class Method 
    {
        protected decimal var, mean;
        protected Random rnd = new Random();

        public Method(decimal mean, decimal var) 
        {
            this.var = var;
            this.mean = mean;
        }

        public abstract double getNum();
       
    }
}
