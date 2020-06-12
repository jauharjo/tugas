using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    class Dinamometer : IAlatUkur
    {
        public void Menghitung()
        {
            Console.WriteLine("> Dinamometer Untuk Menghitung Gaya");
            Console.WriteLine("> Gaya Memiliki Satuan Newton(N)");
        }
    }
}
