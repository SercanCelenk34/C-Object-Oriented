//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimProtected
{
    class x1
    {
        public int kisakenar = 0;

        protected double alan()
        {
            double sonuc;
            sonuc = kisakenar * kisakenar / 2;
            return sonuc;
        }
    }
    class x2 : x1
    {
        public double yenialan()
        {
            double sonuc;
            sonuc=alan() * 2;
            return sonuc;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            x2 xxx = new x2();
            double alann;
            xxx.kisakenar = 30;
            alann = xxx.yenialan();
            Console.WriteLine(alann);
            Console.ReadLine();
        }
    }
}
