//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcIceStaticClass
{
    class Matematik
    {
        public static int Toplam(int x, int y)
        {
            int z = x + y;
            return z;
        }

        public static int Carpim(int x, int y)
        {
            int z = x * y;
            return z;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = Matematik.Toplam(3, 5);
            Console.WriteLine("Toplam="+sonuc);
            int sonuc2 = Matematik.Carpim(3, 5);
            Console.WriteLine("Carpim="+sonuc2);
            Console.ReadLine();
        }
    }
}
