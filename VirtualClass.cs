//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualClass
{

    class dikdortgen
    {
        public int uzunkenar;
        public int kisakenar;

        public virtual double alan()
        {
            double sonuc;
            sonuc = this.uzunkenar * this.kisakenar;
            return sonuc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dikdortgen yenidikdortgen = new dikdortgen();
            yenidikdortgen.kisakenar = 20;
            yenidikdortgen.uzunkenar = 30;
            double sonuc2;
            sonuc2=yenidikdortgen.alan();
            Console.WriteLine(sonuc2);
            Console.ReadLine();
        }
    }
}
