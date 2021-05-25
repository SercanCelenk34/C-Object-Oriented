//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{

    class Urun
    {
        private string urunad;
        private string urunkod;
        private double urunfyt;
        
        public string UrunAd
        {
            get { return urunad; }
            set { urunad = value; }
        }
        
        public string UrunKod
        {
            get { return urunkod; }
            set
            {
                Random rnd = new Random();
                urunkod = value.ToString() + rnd.Next(100, 999).ToString();
            }
        }
        //Kullanıcıdan alınan veriyi yuvarlayıp set ediyoruz.
        public double UrunFyt
        {
            get { return urunfyt; }
            set
            {
                urunfyt = Math.Round(value, 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urn = new Urun();
            urn.UrunAd = "Kursun Kalem";
            urn.UrunKod = "KK";
            urn.UrunFyt = 10.786;

            Console.WriteLine("Ürün Adı: {0} - Ürün Kodu: {1} - Ürün Fiyatı: {2}", urn.UrunAd, urn.UrunKod, urn.UrunFyt);
            Console.ReadLine();
        }
    }
}
