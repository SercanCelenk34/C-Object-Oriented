//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewTh
{

    class Kadro
    {
        public string Isim;
        public Kadro()
        {
            Isim = "Sercan";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kadro ilksinif = new Kadro();
            Console.WriteLine(ilksinif.Isim);
            Console.ReadLine();
        }
    }
}
