using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Setul_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            Console.ReadKey();
        }
        /// <summary>
        /// Extrage si afiseaza a k-a cifra de la sfarsitul unui numar.
        private static void P5()
        {
            int n, k, i, cif=-1,n1;
            Console.Write("Ati ales problema 5. \nIntroduceti valorile pentru n si k:");
            string[] v = Console.ReadLine().Split();
            n = int.Parse(v[0]);
            n1 = n;
            k = int.Parse(v[1]);
            i = 0;
            do
            {
                i++;
                if (i == k)
                    cif = n % 10;
                n = n / 10;
            } while (n != 0);
            if(cif == -1)
                Console.WriteLine($"Numarul k trebuie sa fie mai mic sau egal cu {n}!");
            else
                Console.WriteLine($"A {k}-a cifra a numarului {n1} este: {cif}");

        }

        /// <summary>
        /// Detremina daca un an y este an bisect. 
        /// </summary>
        private static void P4()
        {
            int y;

            Console.Write("Ati ales problema 4. \nIntroduceti valoarea pentru y:");
            string[] v = Console.ReadLine().Split();
            y = int.Parse(v[0]);
            if((y%4 == 0 && y%100!=0 )|| y%400==0)
                Console.WriteLine($"{y} este an bisect");
            else
                Console.WriteLine($"{y} NU este an bisect");
        }

        /// <summary>
        /// Determina daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        private static void P3()
        {
            int n, k ;

            Console.Write("Ati ales problema 3. \nIntroduceti valorile pentru n si k:");
            string[] v = Console.ReadLine().Split();
            n = int.Parse(v[0]);
            k = int.Parse(v[1]);
            if (n % k == 0)
                Console.WriteLine($"{n} este divizibil cu {k}");
            else
                Console.WriteLine($"{n} NU este divizibil cu {k}");
        }

        /// <summary>
        /// Se rezolva o ecuatie de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
        /// </summary>
        private static void P2()
        {
            double a, b, c, x1, x2, delta, xreal, ximaginar;

            Console.Write("Ati ales problema 2. \nIntroduceti valorile pentru a, b si c:");
            string[] v = Console.ReadLine().Split();
            a = double.Parse(v[0]);
            b = double.Parse(v[1]);
            c = double.Parse(v[2]);
            delta = b * b - 4 * a * c;
            if (a == 0)
                Console.WriteLine("Asta nu e ecuatie de gradul 2!");
            else
            {
                if (delta > 0)
                {
                    // caz 1 delta > 0 => x = (-b+sqrt(delta))/2*a
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"Rezolvarile lui x pentru ecuatia {a}x^2 + {b}x + {c} = 0 este: {x1} si {x2}");
                }
                else if (delta == 0)
                {
                    // caz 2 delta = 0 => x1=x2 => x = -b/2a
                    x1 = -b / 2 * a;
                    Console.WriteLine($"Rezolvarea lui x pentru ecuatia {a}x^2 + {b}x + {c} = 0 este: {x1}");
                }
                else
                {
                    delta = -delta;
                    xreal = -b / 2 * a;
                    ximaginar = Math.Sqrt(delta) / 2 * a;
                    Console.WriteLine($"Rezolvarile lui x pentru ecuatia {a}x^2 + {b}x + {c} = 0 este: {xreal} + i*{ximaginar} si {xreal} - i*{ximaginar}");
                }
            }
            
        }

        /// <summary>
        /// Se rezolva o ecuatie de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        private static void P1()
        {
            int a, b, x;
          
            Console.Write("Ati ales problema 1. \nIntroduceti valorile pentru a si b:");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            x = -b / a;
            if((x*a+b)==0)
                Console.WriteLine($"Rezolvarea lui x pentru ecuatia {a}x + {b} = 0 este: {x}");
            else
                Console.WriteLine($"Rezolvarea lui x pentru ecuatia {a}x + {b} = 0 este: -{b}/{a}");
            
        }
    }
}
