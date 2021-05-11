//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcIceStruct
{
    struct bilgi1
    {
        public string isim;
        public int yas;


        public void goster()
        {
            Console.WriteLine(isim);
            Console.WriteLine(yas);

        }
    };
        struct bilgi2
        {
            public string departman;
            public void goster2()
            {
                Console.WriteLine(departman);
            }

        }
   
    class Program
    {
        static void Main(string[] args)
        {
            bilgi1 urun;
            urun.isim = "sercan";
            urun.yas = 23;

            urun.goster();

            bilgi2 urun1;
            urun1.departman = "ceo";
            urun1.goster2();

            Console.ReadLine();

            
        }
    }
}
