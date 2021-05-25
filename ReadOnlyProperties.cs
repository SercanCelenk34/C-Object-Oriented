//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyProperties
{
    class islemyap
    {
        public int x = 0;
        public int y = 0;

        public double hesapla
        {
            get
            {
                double sonuc;
                sonuc = 5 * 3 * x * y * 2 * 6 / 13;
                return sonuc;
            }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            islemyap ilkislem = new islemyap();
            double sonsonuc;
            ilkislem.x = 3;
            ilkislem.y = 6;
            sonsonuc = ilkislem.hesapla;
            Console.WriteLine("Denklem sonucu="+sonsonuc);
            Console.ReadLine();
        }
    }
}
