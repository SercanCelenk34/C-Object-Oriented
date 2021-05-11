//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace IcIceStatikClasslar
{
    
    static class B
    {
        public static string Marka = "Apple";
        public static void MarkaGoster()
        {
            System.Windows.Forms.MessageBox.Show(Marka);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
