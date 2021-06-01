//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{

    struct kisibilgisi
    {
        public string ad;
        public string soyad;
        public string meslek;
        public int tcno;
        
        

        public void yazdir()
        {
            Console.WriteLine("kisi bilgileri=Ismi {0} {1}, Meslegi {2} ve tcno'su {3}'dur.", ad, soyad, meslek, tcno);
        }
        public struct xy_
        {
            public string departman;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            kisibilgisi ceo;
            ceo.ad = "sercan";
            ceo.soyad = "celenk";
            ceo.meslek = "pcEngineer";
            ceo.tcno = 124124;
            ceo.yazdir();
            Console.ReadLine();


        }
    }
}
