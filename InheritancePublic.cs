//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımPublic
{
    class y
    {
        public string isim = "Sercan";
        public void gonderi()
        {
            Console.WriteLine(isim);
        }
    }
    class x : y { }
    
    class Program
    {
        static void Main(string[] args)
        {
            y y1 = new y();
            Console.WriteLine(y1.isim);
            Console.ReadLine();
        }
    }
}
