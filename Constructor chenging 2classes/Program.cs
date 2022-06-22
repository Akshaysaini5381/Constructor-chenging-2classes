using System;

namespace Constructor_chenging_2classes
{

    class MyClass
    {
         public MyClass(int num)
        {
            Console.WriteLine("Hello :"+num);
        }
    }
    class Program:MyClass
    {
        public Program():base(100)
        {
            Console.WriteLine("Hiii :");
        }
        static void Main(string[] args)
        {
            MyClass obj = new Program();
            
         /*   Output
             
            Hello: 100
             Hiii:
         */
        }
    }
}
