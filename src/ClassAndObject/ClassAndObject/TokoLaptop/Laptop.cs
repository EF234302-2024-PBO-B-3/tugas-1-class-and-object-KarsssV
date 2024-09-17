using System;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        // Properti publik untuk Merk, Prosesor, Ram, dan Penyimpanan
        public string Merk { get; set; }
        public string Prosesor { get; set; }
        public int Ram { get; set; } // RAM dalam GB
        public int Penyimpanan { get; set; } // Kapasitas penyimpanan dalam GB

        // Konstruktor yang menginisialisasi properti
        public Laptop(string merk, string prosesor, int ram, int penyimpanan)
        {
            Merk = merk;
            Prosesor = prosesor;
            Ram = ram;
            Penyimpanan = penyimpanan;
        }

        // Metode untuk menampilkan spesifikasi laptop
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }
}
