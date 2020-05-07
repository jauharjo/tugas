using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Canon : PrinterWindows
    {
        public Canon(string nama, string dimesion) : base(nama, dimesion)
        {
        }
    }
}
