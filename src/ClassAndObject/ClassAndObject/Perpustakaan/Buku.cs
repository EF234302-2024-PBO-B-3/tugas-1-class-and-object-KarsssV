using System;

namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        // Public properties for Judul, Penulis, and TahunTerbit
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int TahunTerbit { get; set; }

        // Constructor that initializes the properties
        public Buku(string judul, string penulis, int tahunTerbit)
        {
            Judul = judul;
            Penulis = penulis;
            TahunTerbit = tahunTerbit;
        }

        // Method to display book information
        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
        }
    }
}
