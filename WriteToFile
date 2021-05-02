//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassDegerleriniDosyayaYazdir
{
        
    
    class Program
    {
        static void Main(string[] args)
        {
            fonksiyonlar x = new fonksiyonlar();
           x.DosyayaYaz();

      
            x.DosyadanOku("C:\\Users\\Hp\\source\\repos\\ClassDegerleriniDosyayaYazdir\\deneme.txt");

            
            x.DosyayaEkle("C:\\Users\\Hp\\source\\repos\\ClassDegerleriniDosyayaYazdir\\deneme.txt");

            Console.ReadLine();
        }

        public class fonksiyonlar
        {
            public void DosyayaYaz()
            {
           
                StreamWriter dosya = new StreamWriter("C:\\Users\\Hp\\source\\repos\\ClassDegerleriniDosyayaYazdir\\deneme.txt");

                
                dosya.WriteLine("sercancelenk");

                
                dosya.WriteLine("İ172119014");

               
                dosya.Close();

                Console.WriteLine("Dosya yazımı Başarı ile tamamlandı...");

            }

            public void DosyadanOku(string dosyaIsmi)
            {
                StreamReader dosyaOku;

                string yazi;

              
                dosyaOku = File.OpenText(dosyaIsmi);

               
                yazi = dosyaOku.ReadLine();

              

                while (yazi != null)
                {
                    Console.WriteLine(yazi);
                    yazi = dosyaOku.ReadLine();
                }

                
                dosyaOku.Close();
            }

            public void DosyayaEkle(string dosyaIsmi)
            {
                
                StreamWriter dosya;

               
                dosya = File.AppendText(dosyaIsmi);

                
                dosya.WriteLine("Bu okudugunuz satir append ile eklenmistir.");

                dosya.Close();

                Console.WriteLine("Dosyanın sonuna başarı ile ekledik...");
            }
        }

    }
}
