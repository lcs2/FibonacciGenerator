using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciag_fibo
{
    class Program
    {
        static decimal x = 0;
        static decimal y = 0;
        static int i;
        static void Main(string[] args)
        {
            var c = new ConsoleKeyInfo();
            Start();
            do
            {
                c = Console.ReadKey(true);
                if ( c.Key == ConsoleKey.R) Start();
                Console.WriteLine($"{++i, 4}. x: {x, 20}\t y:\t{y, 20}\t, fi = {(decimal)y / x}\t");
                var z = x + y;
                x = y;
                y = z;
            }
            while (c.Key != ConsoleKey.Q);
        }
        static void Start()
        {
            i = 0;
            Console.WriteLine("podaj 2 liczby:");
            x = Convert.ToInt64(Console.ReadKey().KeyChar - '0');
            y = Convert.ToInt64(Console.ReadKey().KeyChar - '0');
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Klikaj aby robic powtorzenia (R - reset, Q - wyjscie):");
        }
    }
}
