using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolyDanCol.ClassAnak
{
    class KaryawanTetap : ClassInduk.Karyawan
    {
        public double GajiBulanan { get; set; }

        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
