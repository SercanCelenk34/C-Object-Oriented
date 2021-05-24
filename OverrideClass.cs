//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideClass
{ 
    class dikdortgen
{
    public int uzunkenar;
    public int kisakenar;
    public virtual double alan()
    {
        double sonuc;
        sonuc = this.uzunkenar * this.kisakenar;
        return sonuc;
    }
}

class altigen : dikdortgen
{
    public override double alan()
    {
        double sonuc;
        sonuc = base.alan() * 2;
        return sonuc;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            dikdortgen x = new dikdortgen();
            x.uzunkenar = 10;
            x.kisakenar = 5;
            Console.WriteLine(x.alan());

            altigen y = new altigen();
            x.uzunkenar = 15;
            x.kisakenar = 4;
            Console.WriteLine(x.alan());

            Console.ReadLine();




        }
    }
}
