using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    class Speedometer : IAlatUkur
    {
        public void Menghitung()
        {
            Console.WriteLine("- Speedometer Untuk Menghitung Kecepatan");
            Console.WriteLine("- Kecepatan Memiliki Satuan Meter/Second(m/s)");
        }
    }
}
