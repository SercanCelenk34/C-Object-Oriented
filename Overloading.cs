//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
   

    
    class Program
    {
        static void Main(string[] args)
        {
            int tamtopla(int x, int y)
            {
                return x + y;
            }
           double virgullutopla(double x, double y)
            {
                return x + y;
            }

            int islem1 = tamtopla(12, 8);

            double islem2 = virgullutopla(12.2, 8.8);
            Console.WriteLine(islem1);
            Console.WriteLine(islem2);
            Console.ReadLine();


        }
    }
}
