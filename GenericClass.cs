//Author:SercanCelenk

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GenericSiniflar
{

    class x<Tip>
    {
        public Tip veri;
        public void gonderi()
        {
            Console.WriteLine(veri);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            x<string> next = new x<string>();
            next.veri = "Sercan";
            next.gonderi();
            Console.ReadLine();
        }
    }
}
