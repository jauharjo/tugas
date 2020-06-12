using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    class Barometer : IAlatUkur
    {
        public void Menghitung()
        {
            Console.WriteLine("+ Barometer Untuk Menghitung Tekanan Udara");
            Console.WriteLine("+ Tekanan Udara Memiliki Satuan Atmosfer(atm)");
        }
    }
}
