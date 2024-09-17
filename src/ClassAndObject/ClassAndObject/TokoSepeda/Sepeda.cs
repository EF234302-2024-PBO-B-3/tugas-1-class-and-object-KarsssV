using System;
using System.Globalization;

namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        // Properti publik untuk Merk, Tipe, dan Berat
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public double Berat { get; set; } // Berat dalam kilogram

        // Konstruktor yang menginisialisasi properti
        public Sepeda(string merk, string tipe, double berat)
        {
            Merk = merk;
            Tipe = tipe;
            Berat = berat;
        }

        public void TampilkanInformasi()
        {
            // Menggunakan Console.Write tanpa menambahkan newline otomatis
            Console.Write($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat.ToString("F1", CultureInfo.InvariantCulture)} kg{Environment.NewLine}");
        }
    }
}
