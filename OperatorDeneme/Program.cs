using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///atama işlemi
            int y;
            int x;

            y = 10;
            x = 5;

            y += 10;
            x *= 2;

            Console.WriteLine(x);   
            Console.WriteLine(y);


            ///mantıksal operator ||, &&, !
            /// || veya
            /// && ve 
            /// ! değil demek
            int u, v;
            u = 10; v = 5;
            if (u == 10 && v ==5)
            {
                Console.WriteLine("correct");
            }
            if (v !=4)
            {
                Console.WriteLine("inaccurate");
            }

            if (u ==10 || v == 3)
            {
                Console.WriteLine("one data is correct, check");
            }


            /// ilişkisel operatorler
            /// <, >, <=, >=, ==, !=

            



            /// aritmetik operatorler
            /// +,-,*,/
            /// 
            int f, g;
            int k;
            int p;
            int pp;
            f = 18;
            g = 1;
            p = f / g; // + - *
            Console.WriteLine("asses to k:");
            k = Convert.ToInt32(Console.ReadLine());
            pp = k / f;
            Console.WriteLine(pp);
                    


            if (pp <=1)
            {
                Console.WriteLine("Number is equal or lower than 1");

            }

            if (pp > 1)
            {
                Console.WriteLine("number is bigger than 1");
            }

            int nn;
            nn = ++f;
            Console.WriteLine(nn);

            

        }
    }
}
