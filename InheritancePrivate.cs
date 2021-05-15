//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımPrivate
{
   
    class x
    {
        public string isim = "Sercan Celenk";
        private void gonderi()
        {
            Console.WriteLine(isim);
        }
    }
    
    
    class Program
   
    {

        
        static void Main(string[] args)
        {
            x x1 = new x();
            Console.WriteLine(x1.isim);
            Console.ReadLine();
        }
    }
}
