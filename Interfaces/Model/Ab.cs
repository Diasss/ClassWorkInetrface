using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    public class Ab : A, ISqrSqrt
    {
        public int Sqr(int x)
        {
            return x * x;
        }

        public int Sqrt(int x)
        {
            return (int)Math.Sqrt((double)x);
        }
    }
}
