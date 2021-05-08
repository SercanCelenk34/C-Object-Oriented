//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarkliDegiskenClass
{
    class x
    {
        public string isim = "Sercan";
        public void gonderi()
        {
            Console.WriteLine(isim);
        }
    }
    class y : x
    {
        public string konum = "Istanbul";
        public void goster()
        {
            Console.WriteLine(konum);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            y xx = new y();
            Console.WriteLine(xx.isim);
            Console.WriteLine(xx.konum);
            Console.ReadLine();
        }
    }
}
