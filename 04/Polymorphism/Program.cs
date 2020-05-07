using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laser Jet\n");

            Console.WriteLine("Pilih Printer [1..3] :");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson("Epson", "10*11");
            else if (nomorPrinter == 2)
                printer = new Canon("Canon", "9.5*12");
            else
                printer = new LaserJet("LaserJet", "12*12");

            printer.Tampilkan();
            Console.ReadKey();
        }
    }
}
