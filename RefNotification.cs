//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefBildiri
{

    class refbildiri
    {
        public void gonderi(ref string veri)
        {
            veri = "Sercan";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string x = "ahmet";
            refbildiri refbildiri1 = new refbildiri();
            refbildiri1.gonderi(ref x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
