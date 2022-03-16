using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengkurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Title = "Console Calculator";
         menu:
            Console.WriteLine("========== Selamat Datang Di Console Calculator ==========");
            Console.WriteLine();
            Console.WriteLine("|                     1. Penjumlahan                     |");
            Console.WriteLine("|                     2. Perkurangan                     |");
            Console.WriteLine("|                     3. Perkalian                       |");
            Console.WriteLine("|                     4. Pembagian                       |");
            Console.WriteLine("|                     5. Keluar                          |");
            Console.WriteLine();
            Console.Write("Mau Pilih Menu Berapa Nih? [1-5] = ");
            int pilih = int.Parse(Console.ReadLine());
            if (pilih == 1)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Kedua   : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2} ", a, b, Penambahan(
                    a, b));
                Console.WriteLine("\nTekan Sembarang Untuk Kembali Ke Menu Utama");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }else if(pilih == 2)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Kedua   : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Hasil Pengkurangan {0} - {1} = {2} ", a, b, Pengkurangan(
                    a, b));
                Console.WriteLine("\nTekan Sembarang Untuk Kembali Ke Menu Utama");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }else if (pilih == 3)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Kedua   : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(
                    a, b));
                Console.WriteLine("\nTekan Sembarang Untuk Kembali Ke Menu Utama");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            else if (pilih == 4)
            {
                Console.WriteLine();
                Console.Write("Masukan Nilai Pertama : ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai Kedua   : ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(
                    a, b));
                Console.WriteLine("\nTekan Sembarang Untuk Kembali Ke Menu Utama");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }else if (pilih == 5)
            {
                Console.WriteLine();
                Console.WriteLine("TERIMAKASIH TELAH MENGGUNAKAN CONSOLE CALCULATOR :)");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("\nTekan Sembarang Untuk Keluar");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("\nPilihan Tidak Tersedia Tekan Sembarang Untuk Kembali");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }


        }

    }
}
