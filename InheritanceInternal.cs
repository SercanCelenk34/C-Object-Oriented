//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitimİnternal
{

    class internallx
    {
        internal string isim = "sercan";
        public internallx(string deger)
        {
            isim = deger;
        }
        internal void gonderi()
        {
            Console.WriteLine(isim);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "tusem";
            internallx x1 = new internallx(ad);
            x1.gonderi();
            Console.ReadLine();
        }
    }
}
