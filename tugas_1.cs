using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float hasil;

            Console.Title = "Ini Kalkulator";

            Console.WriteLine("==========================");
            Console.WriteLine("Pilih Menu Kalkulator :");
            Console.WriteLine("==========================\n");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("\n==========================");
            Console.WriteLine("Input nomor menu [1-4] :");
            int menu = int.Parse(Console.In.ReadLine());

            //input
            Console.Write("\nInputkan nilai a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Inputkan nilai b =");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //menu
            if ( menu == 1) {
                    hasil = a + b;
                    Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penjumlahan(a, b));
                    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                    Console.ReadKey();
            }

            else if ( menu == 2) {
                    hasil = a - b;
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                    Console.ReadKey();
            }
            
            else if ( menu == 3) {
                    hasil = a * b;
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                    Console.ReadKey();
            }

            else if ( menu == 4) {
                    hasil = a / b;
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    Console.WriteLine("Tekan sembarang tombol untuk keluar");
                    Console.ReadKey();
            }
            else {
                    Console.WriteLine("Maaf, Menu yang kamu pilih tidak tersedia");
            }

        }

        //fungsi
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}