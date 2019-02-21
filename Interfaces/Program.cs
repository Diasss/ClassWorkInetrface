using Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A(x: 10, y: 12);
            Console.WriteLine("obj: ");
            obj.Rewrite();
            Console.WriteLine("{0} + {1} = {2}", obj.x, obj.y, obj.Sum());
            Test(obj); 
        }
        static void Test(Ioperator o)
        {

        }
    }
}
