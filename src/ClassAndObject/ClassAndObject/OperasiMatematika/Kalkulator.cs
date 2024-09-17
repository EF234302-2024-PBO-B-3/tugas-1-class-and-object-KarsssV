using System;

namespace ClassAndObject.OperasiMatematika
{
    public class Kalkulator
    {
        // Metode untuk penjumlahan
        public double Tambah(double a, double b)
        {
            return a + b;
        }

        // Metode untuk pengurangan
        public double Kurang(double a, double b)
        {
            return a - b;
        }

        // Metode untuk perkalian
        public double Kali(double a, double b)
        {
            return a * b;
        }

        // Metode untuk pembagian
        public double Bagi(double a, double b)
        {
            if (b == 0)
            {
                // Kembalikan PositiveInfinity untuk pembagian dengan nol
                return double.PositiveInfinity;
            }
            return a / b;
        }
    }
}
