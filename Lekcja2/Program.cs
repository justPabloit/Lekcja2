using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 9;
            //int c;
            //int d;
            //c = a + b;
            //a += b;

            //d = b % a;

            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //// inkrementacja
            //a++;
            //Console.WriteLine(a);
            // operatory logiczne
            //bool a = 2 > 1;
            //bool b = 2 == 2;
            //bool c = 2 != 2;
            //bool d = !(2 == 2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //int a = 2 + 2 * 2;
            //Console.WriteLine(a);

            bool a = 1 == 1 && 1!=1;// I, AND
            bool b = 1 == 1 || 2 != 2;// LUB , OR
            bool c = true || true && false;
            bool d = (true || true) && false;
            

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Abs(-5));




            Console.ReadKey();
        }
    }
}
