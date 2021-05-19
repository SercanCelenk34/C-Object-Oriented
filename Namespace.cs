//Author:SercanCelenk
using Namespace.Merkez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    namespace Merkez
    {
        class Yonetim
        {
            public string mudurad = "SercanCelenk";
            public void adgoster()
            {
                Console.WriteLine(mudurad);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           Merkez.Yonetim icrakurulu = new Merkez.Yonetim();
            icrakurulu.adgoster();
            Console.ReadLine();
        }
    }
}
