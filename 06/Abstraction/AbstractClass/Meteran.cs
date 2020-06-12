using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    class Meteran : AlatUkur
    {
        public override void Menghitung()
        {
            Console.WriteLine("+ Meteran Untuk Menghitung Panjang");
            Console.WriteLine("+ Panjang Meniliki Satuan Meter(m)");
        }
    }
}
