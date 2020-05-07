using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class LaserJet : PrinterWindows
    {
        public LaserJet(string nama, string dimesion) : base(nama, dimesion)
        {
        }
    }
}
