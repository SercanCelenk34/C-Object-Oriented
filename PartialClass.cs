//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{

    partial class x
    {
        public string isim = "sercan";

    }

    partial class x
    {
        public void gonderi()
        {
            Console.WriteLine(isim);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            x y = new x();
            y.gonderi();
            Console.ReadLine();

        }
    }
}
