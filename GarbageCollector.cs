//Author:SercanCelenk
using System;

namespace SiniflariTemizlemeGarbage
{

    class Oyuncu
    {
        public static int OyuncuSayisi = 0;
        public string KullaniciAdi;
        public string Sifre;
        public int Skor;
        public Oyuncu()
        {
            OyuncuSayisi++;
        }
        ~Oyuncu()
        {
            OyuncuSayisi--;  //Garbage Collector
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Oyuncu oyuncu1 = new Oyuncu();
            Oyuncu oyuncu2 = new Oyuncu();

            Console.WriteLine("Mevcut oyuncu sayisi=" + Oyuncu.OyuncuSayisi);
            Console.Write("Bellek basari ile temizlendi.");

            Console.ReadLine();
            }
    }
}

