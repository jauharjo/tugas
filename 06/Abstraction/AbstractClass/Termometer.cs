using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    class Termometer : AlatUkur
    {
        public override void Menghitung()
        {
            Console.WriteLine("- Termometer Untuk Menghitung Temperatur");
            Console.WriteLine("- Temperatur Memiliki Satuan Celcius(C)");
        }
    }
}
