using System;
using ClassAndObject.Kendaraan;
using ClassAndObject.OperasiMatematika;
using ClassAndObject.Perpustakaan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku = new Buku("Pemrograman C#", "John Doe", 2023);
            buku.TampilkanInfo(); // Display the book information



            // Kendaraan
            Mobil mobil = new Mobil("Toyota", "Camry", 2022);
            mobil.TampilkanSpesifikasi(); // Menampilkan spesifikasi mobil




            // Laptop
            Laptop laptop = new Laptop("Dell", "Intel Core i7", 16, 512);
            laptop.TampilkanSpesifikasi(); // Menampilkan spesifikasi laptop



            // Sepeda
            Sepeda sepeda = new Sepeda("Polygon", "Mountain Bike", 14.5);
            sepeda.TampilkanInformasi(); // Menampilkan informasi sepeda



            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();
            double hasilTambah = kalkulator.Tambah(10, 5);
            double hasilKurang = kalkulator.Kurang(10, 5);
            double hasilKali = kalkulator.Kali(10, 5);
            double hasilBagi = kalkulator.Bagi(10, 5);

            Console.WriteLine($"Hasil Tambah: {hasilTambah}");
            Console.WriteLine($"Hasil Kurang: {hasilKurang}");
            Console.WriteLine($"Hasil Kali: {hasilKali}");
            Console.WriteLine($"Hasil Bagi: {hasilBagi}");



        }
    }
}
