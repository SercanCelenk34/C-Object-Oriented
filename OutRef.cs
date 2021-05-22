//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutBildiri
{

    class x1
    {
        public void gonderi(out string veri)
        {
            string newveri;
            veri = "Sercan";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string deger;
            deger = "Umut";
            x1 xx = new x1();
            xx.gonderi(out deger);
            Console.WriteLine(deger);
            Console.ReadLine();
        }
    }
}
