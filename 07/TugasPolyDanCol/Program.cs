using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasPolyDanCol.ClassAnak;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Pertemuan 11 - Polymorphism & Collection";

            KaryawanTetap KT = new KaryawanTetap();
            KT.Nik = "012-345";
            KT.Nama = "Nur";
            KT.GajiBulanan = 4000000;

            KaryawanHarian KH = new KaryawanHarian();
            KH.Nik = "123-456";
            KH.Nama = "Jauhar";
            KH.JumlahJamKerja = 8;
            KH.UpahPerJam = 13000;

            Sales S = new Sales();
            S.Nik = "234-567";
            S.Nama = "Muslih";
            S.JumlahPenjualan = 30;
            S.Komisi = 45000;

            List<Karyawan> LK = new List<Karyawan>();
            LK.Add(KT);
            LK.Add(KH);
            LK.Add(S);

            int noUrut = 1;

            foreach (Karyawan karyawan in LK)
            {
                Console.WriteLine("{0).Nik : {1}, Nama : {2}, Gaji  : {3:NO}",
                    noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
