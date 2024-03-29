﻿using System;

namespace percobaan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator Sederhana";

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Silakan pilih operasi matematika yang ingin Anda lakukan:");
                Console.WriteLine("=========================================================");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("==================================");
                Console.WriteLine("Masukkan pilihan anda:");
                string input = (Console.ReadLine());

                if (input == "1")
                {
                    Console.WriteLine("Penjumlahan"); 
                }
                else if (input == "2")
                {
                    Console.WriteLine("Pengurangan");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Perkalian");
                }
                else if (input == "4")
                {
                    Console.WriteLine("Pembagian");
                }
                else
                {
                    Console.WriteLine("Operasi yang anda pilih salah!");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("==================================");
                Console.WriteLine("Masukkan nilai a:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Masukkan nilai b:");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("==================================");
                int hasil = 0;

                if (input == "1")
                {
                    hasil = Penjumlahan(a, b);
                }
                else if (input == "2")
                {
                    hasil = Pengurangan(a, b);
                }
                else if (input == "3")
                {
                    hasil = Perkalian(a, b);
                }
                else if (input == "4")
                {
                    hasil = Pembagian(a, b);
                }
                else
                {
                    Console.WriteLine("Operasi yang dipilih tidak valid.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Hasil operasi: "+ hasil) ;
                
                Console.WriteLine("Apakah Anda ingin melakukan operasi matematika lagi? (y/n)");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "n")
                {
                    isRunning = false;
                }
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

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
