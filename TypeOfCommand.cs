//Author:SercanCelenk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TypeofKomutu
{
   

        // Here store Type as a field 
        
    

        class Program
    {
        static void Main(string[] args)
        {
            Type a = typeof(double);

            Console.WriteLine(a);

          
            Console.WriteLine(typeof(int));

          
            Console.WriteLine(typeof(Array));

          
            Console.WriteLine(typeof(char));

          
            Console.WriteLine(typeof(int[]));
            Console.ReadLine();
        }
    }
    }

