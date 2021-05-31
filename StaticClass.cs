//Author:SercanCelenk
using System;

namespace StatikClass
{

    // Outer class 
    public class Ilk_class
    {

        // Method of outer class 
        public void method1()
        {
            Console.WriteLine("Ilk class basariyla cagirildi !");
        }

        // Inner class 
        public class Ikinci_class
        {

            // Method of inner class 
            public void method2()
            {
                Console.WriteLine("Ikinci class basariyla cagirildi !");
            }
        }
    }

    // Driver Class 
    public class GFG
    {

        // Main method 
        static public void Main()
        {

            // Create the instance of outer class 
            Ilk_class obj1 = new Ilk_class();
            obj1.method1();

            // This statement gives an error because 
            // you are not allowed to access inner  
            // class methods with outer class objects 
            // obj1. method2(); 

            // Creating an instance of inner class 
            Ilk_class.Ikinci_class obj2 =
                        new Ilk_class.Ikinci_class();

            // Accessing the method of inner class 
            obj2.method2();

            Console.ReadLine();
        }
    }
}
