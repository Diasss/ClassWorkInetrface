using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    public class A : Ioperator
    {
        public int x { get; set; }
        public int y { get; set; }
        public A()
        {

        }
        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Del()
        {
            return x / y;
        }

        public int Otr()
        {
            return x - y;
        }

        public int Prx()
        {
            return x * y;
        }

        public virtual int Sum()
        {
            return x + y;
        }
        public virtual void Rewrite()
        {
            Console.WriteLine("Переменная x: {0}" +
                "\nПеременная y: {1}", x, y);
        }
    }
}
