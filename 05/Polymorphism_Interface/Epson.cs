using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer is printing.....");
        }
    }
}
