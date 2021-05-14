//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    interface IKisi
    {
        string adSoyad { get; set; }
        string adres { get; set; }
        string departman { get; set; }
        void bilgi();
    }


    class Yonetici : IKisi
    {
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }
        public void bilgi()
        {
            Console.WriteLine(" {0} isimli çalışan {1} departmanında yöneticidir.", adSoyad, departman);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Yonetici x = new Yonetici();
            x.adSoyad = "Sercan";
            x.adres = "Istanbul";
            x.departman = "CEO";

            x.bilgi();
            Console.ReadLine();
        }
    }
}
