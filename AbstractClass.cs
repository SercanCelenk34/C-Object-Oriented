//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class x
    {
        public string marka = "Nike";
        public void markagoster()
        {
            Console.WriteLine(marka);
        }
    }
    class y : x
    {
        public int fiyatortalamasi = 150;
       
    }


    class Program
    {
        static void Main(string[] args)
        {
            y ilkclass = new y();

            Console.WriteLine(ilkclass.marka);
            Console.WriteLine(ilkclass.fiyatortalamasi);
            Console.ReadLine();
        }
    }
}
