//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Hastane
    {
        public string isim { get; set; }
        public int ID { get; set; }

        private string[] isimler = new string[5];
        public string this[int index]
        {
            get
            {
                return isimler[index];
            }
            set
            {
                isimler[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hastane ZeynepKamil = new Hastane();

            ZeynepKamil[0] = "Bilgi İşlem";
            ZeynepKamil[1] = "Poliklinikler";
            ZeynepKamil[2] = "Ameliyathane";
            ZeynepKamil[3] = "Satın alma";
            ZeynepKamil[4] = "Acil Servis";

            Console.WriteLine(ZeynepKamil[4]);

            Console.ReadLine();



        }
    }
}
