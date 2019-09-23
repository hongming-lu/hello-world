using System;

namespace ConsoleApp1
{
    class Program
    {
         class Vecter
        {
          public  int Value;
        }

        static void Main(string[] args)
        {
            Vecter x, y;
            x = new Vecter ();
            x.Value=30;
            y = x;
            Console.WriteLine(y.Value );
            Console.WriteLine(x.Value);
            y.Value  = 50;

            Console.WriteLine(x.Value);

        }
    }
}
