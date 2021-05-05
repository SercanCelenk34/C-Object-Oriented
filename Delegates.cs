//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class delegatee
    {
        public string marka1 = "bmw";
        public string marka2 = "honda";
        public string marka3 = "toyota";

        public void markagoster1()
        {
            Console.WriteLine(marka1);
        }
        public void markagoster2()
        {
            Console.WriteLine(marka2);
        }
        public void markagoster3()
        {
            Console.WriteLine(marka3);
        }

        public delegate void Proc();
        public Proc delege;
    }




    class Program
    {
        static void Main(string[] args)
        {
            delegatee x = new delegatee();
            x.delege += new delegatee.Proc(x.markagoster1);

            x.delege += new delegatee.Proc(x.markagoster2);

            x.delege += new delegatee.Proc(x.markagoster2);

            Console.WriteLine(x.marka1);

            Console.WriteLine(x.marka2);

            Console.WriteLine(x.marka3);

            Console.ReadLine();

        }
    }
}
