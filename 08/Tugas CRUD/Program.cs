using System;
using System.Collections.Generic;
using Tugas_CRUD.ClassAnak;
using Tugas_CRUD.ClassInduk;

namespace Tugas_CRUD
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Karyawan> karyawan = new List<Karyawan>();

            KaryawanTetap KT = new KaryawanTetap();
            KT.Nik = "012-345";
            KT.Nama = "Nur";
            KT.GajiBulanan = 4000000;

            KaryawanHarian KH = new KaryawanHarian();
            KH.Nik = "123-456";
            KH.Nama = "Jauhar";
            KH.JumlahJamKerja = 8;
            KH.UpahPerJam = 13000;

            Sales KS = new Sales();
            KS.Nik = "234-567";
            KS.Nama = "Muslih";
            KS.JumlahPenjualan = 30;
            KS.Komisi = 45000;

            karyawan.Add(KT);
            karyawan.Add(KH);
            karyawan.Add(KS);

            Menu(karyawan);
        }

        static void Menu(List<Karyawan> karyawan)
        {
            bool status = true;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("\tDATA KARYAWAN");
                Console.WriteLine("==============================");
                Console.WriteLine("Silahkan Pilih: ");
                Console.WriteLine("1. Tambahkan Data");
                Console.WriteLine("2. Tampilkan Data");
                Console.WriteLine("3. Hapus Data");
                Console.WriteLine("4. KELUAR");

            getOption:
                string opsi;
                Console.Write("Input Pilihan [1..4]: ");
                opsi = Console.ReadLine();

                if (opsi == "1")
                {
                    InputData(karyawan);
                    Kembali();
                }
                else if (opsi == "2")
                {
                    ReadData(karyawan);
                    Kembali();
                }
                else if (opsi == "3")
                {
                    ReadData(karyawan);
                    DeleteData(karyawan);
                    Kembali();
                }
                else if (opsi == "4")
                {
                    status = false;
                }
                else
                {
                    Console.WriteLine("Pilihan Tidak Sesuai [1..4] !");
                    goto getOption;
                }

            } while (status);
        }

        static void InputData(List<Karyawan> karyawan)
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("\tINPUT KARYAWAN");
            Console.WriteLine("==============================");
            Console.WriteLine("Pilih Jenis Karyawan : ");
            Console.WriteLine("1. Karyawan Tetap");
            Console.WriteLine("2. Karyawan Harian");
            Console.WriteLine("3. Sales");

        getOption:
            string opsi;
            Console.Write("Input Pilihan [1..3]: ");
            opsi = Console.ReadLine();
            Console.WriteLine();

            if (opsi == "1")
            {
                KaryawanTetap KT= new KaryawanTetap();

                Console.WriteLine("Input Karyawan Tetap");

                Console.Write("Input Nik \t\t: ");
                KT.Nik = Console.ReadLine();

                Console.Write("Input Nama \t\t: ");
                KT.Nama = Console.ReadLine();

                Console.Write("Input Gaji Bulanan \t: ");
                KT.GajiBulanan = Convert.ToDouble(Console.ReadLine());

                karyawan.Add(KT);

            }
            else if (opsi == "2")
            {
                KaryawanHarian KH = new KaryawanHarian();
                Console.WriteLine("Input Karyawan Harian");

                Console.Write("Input Nik \t\t: ");
                KH.Nik = Console.ReadLine();

                Console.Write("Input Nama \t\t: ");
                KH.Nama = Console.ReadLine();

                Console.Write("Input Upah per Jam \t: ");
                KH.UpahPerJam = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input Jam Kerja \t: ");
                KH.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());

                karyawan.Add(KH);

            }
            else if (opsi == "3")
            {
                Sales KS = new Sales();
                Console.WriteLine("Input Karyawan Harian");

                Console.Write("Input Nik \t\t: ");
                KS.Nik = Console.ReadLine();

                Console.Write("Input Nama \t\t: ");
                KS.Nama = Console.ReadLine();

                Console.Write("Input Jumlah Penjualan \t: ");
                KS.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input Komisi \t\t: ");
                KS.Komisi = Convert.ToDouble(Console.ReadLine());

                karyawan.Add(KS);
            }
            else
            {
                Console.WriteLine("Pilihan Tidak Sesuai [1..3] !");
                goto getOption;
            }
        }

        static void ReadData(List<Karyawan> karyawan)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | Nik \t | NAMA\t\t | Gaji\t\t |");
            Console.WriteLine("==================================================");
            for (int i = 0; i < karyawan.Count; i++)
            {
                Console.WriteLine(" {0}. | {1} \t | {2} \t | {3} \t |", i + 1, karyawan[i].Nik, karyawan[i].Nama, karyawan[i].Gaji());
            }
        }

        static void DeleteData(List<Karyawan> karyawan)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("\tHAPUS KARYAWAN");
            Console.WriteLine("==============================");

            bool found = true;
            string Nik;
            Console.Write("Input Nik Karyawan: ");
            Nik = Console.ReadLine();

            for (int i = 0; i < karyawan.Count; i++)
            {
                if (karyawan[i].Nik == Nik)
                {
                    karyawan.Remove(karyawan[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Data dengan Nik = {0} tidak ditemukan", Nik);
            }
            else
            {
                Console.WriteLine("Data dengan Nik = {0} berhasil diDelete", Nik);
            }
        }

        static void Kembali()
        {
            Console.WriteLine("\nTekan Sembarang Tombol untuk kembali ke Menu");
            Console.ReadKey();
        }
    }
}
