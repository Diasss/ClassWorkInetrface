using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    public class AA:A
    {
        public AA(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public int z { get; set; }
        public override int Sum()
        {
            return base.x + base.y + this.z;
        }
        public override void Rewrite()
        {
            base.Rewrite();
            Console.WriteLine("Переменная z: {0}", z);
        }
    }
}
