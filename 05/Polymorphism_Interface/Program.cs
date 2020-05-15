using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows printer;

            Console.WriteLine("Num Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Pilih Printer [1...3]");
            int NumPrinter = Convert.ToInt32(Console.ReadLine());

            if (NumPrinter == 1)
            {
                printer = new Epson();
            }
            else if (NumPrinter == 2)
            {
                printer = new Canon();
            }
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
