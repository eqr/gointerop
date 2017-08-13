using System;
using System.Runtime.InteropServices;
using System.Text;

namespace interop
{
    class Program
    {
        [DllImport("libm")]
        public static extern double sin(double angle);

        [DllImport("libgo.so")]
        public static extern int Add(int a, int b);
        static void Main(string[] args)
        {            
            Console.WriteLine(sin(3.1415 / 2));        
            Console.WriteLine(Add(2,3));      
         }
    }
}