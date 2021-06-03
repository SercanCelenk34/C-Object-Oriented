//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKomutu
{

    class Ogrenci
    {
        private string AdSoyad;
        private int Numara;
        private int Sinif;

        public Ogrenci(string AdSoyad, int Numara, int Sinif)
        {
            this.AdSoyad = AdSoyad;
            this.Numara = Numara;
            this.Sinif = Sinif;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ilkogrenci = new Ogrenci("Sercan", 37, 16);
            Console.WriteLine("bilgiler basari ile get set edildi !");
            Console.ReadLine();

            
        }
    }
}
