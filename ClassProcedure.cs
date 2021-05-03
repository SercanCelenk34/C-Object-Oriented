//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProcedur
{
    class prosedur
    {
        public void gonderi()
        {
            Console.WriteLine("Ilk gorevınız c#");
        }
        public void mesajal(string veri)
        {
            Console.WriteLine(veri);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            prosedur class1 = new prosedur();
            class1.mesajal("merhaba");

            class1.gonderi();


            Console.ReadLine();
        }
    }
}
