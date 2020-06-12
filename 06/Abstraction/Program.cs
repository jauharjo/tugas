using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] agrs)
        {
            IAlatUkur ialatukur;
            Console.WriteLine("\n\tPenggunaan Interface\n");
            ialatukur = new Speedometer();
            ialatukur.Menghitung();
            ialatukur = new Barometer();
            ialatukur.Menghitung();
            ialatukur = new Dinamometer();
            ialatukur.Menghitung();

            AlatUkur alatukur;
            Console.WriteLine("\n\n\tPenggunaan AbstractClass\n");
            alatukur = new Termometer();
            alatukur.Menghitung();
            alatukur = new Meteran();
            alatukur.Menghitung();
            alatukur = new Timbangan();
            alatukur.Menghitung();
            alatukur.Lain();

            Console.ReadKey();
        }
    }
}
