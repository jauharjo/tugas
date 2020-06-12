using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    class Timbangan : AlatUkur
    {
        public override void Menghitung()
        {
            Console.WriteLine("> Timbangan Untuk Menghitung Berat");
            Console.WriteLine("> Berat Memiliki Satuan Kilogram(KG)");
        }
    }
}
