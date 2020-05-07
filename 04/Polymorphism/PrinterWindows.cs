using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public string Nama { get; set; }
        public string Dimensi { get; set; }

        public PrinterWindows(string nama, string dimensi)
        {
            this.Nama = nama;
            this.Dimensi = dimensi;
        }
        public void Tampilkan()
        {
            Console.WriteLine("{0} Display Dimesion : {1}", Nama, Dimensi);
            Console.WriteLine("{0} printer printing....", Nama);
        }
    }
}
