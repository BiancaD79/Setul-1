using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Setul_1
{
    class Program
    {
        static int inversa(int n)
        {
            int inv = 0;
            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n = n / 10;
            }
            return inv;
        }
        static void interschimbare(ref int a, ref int b)
        {
            int aux;
            aux = b;
            b = a;
            a = aux;
        }
        static void Main(string[] args)
        {

            int prob, ok = 1;
            do
            {
                Console.Clear();
                Console.Write("Alegeti o problema: ");
                prob = int.Parse(Console.ReadLine());
                if (prob < 1 || prob > 21) Console.Write("Nu ati introdus un numar corect!");
                else
                {
                    switch (prob)
                    {
                        case 1: P1(); break;
                        case 2: P2(); break;
                        case 3: P3(); break;
                        case 4: P4(); break;
                        case 5: P5(); break;
                        case 6: P6(); break;
                        case 7: P7(); break;
                        case 8: P8(); break;
                        case 9: P9(); break;
                        case 10: P10(); break;
                        case 11: P11(); break;
                        case 12: P12(); break;
                        case 13: P13(); break;
                        case 14: P14(); break;
                        case 15: P15(); break;
                        //case 16: P16(); break;
                        case 17: P17(); break;
                        case 18: P18(); break;
                        case 19: P19(); break;
                        //case 20: P20(); break;
                        //case 21: P21(); break;
                    }

                }
                Console.Write("\nDoriti sa alegeti alta problema?: 0 - Nu, 1 - Da ");
                ok = int.Parse(Console.ReadLine());
            } while (ok != 0);
            
        }
        
        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        /// </summary>
        private static void P19()
        {
            int n,apar=0;
            int[] v = new int[10];
            Console.Write("Determinati daca un numar e format doar cu 2 cifre care se pot repeta.\nIntroduceti o valoare pentru n: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                v[n % 10]++;
                n = n / 10;
            }
            for (int i = 0; i < 10; i++)
            {
                if (v[i] != 0) apar++;
            }
            if (apar == 2) Console.WriteLine($"Numarul este format din 2 cifre care se repeta");
            else Console.WriteLine($"Numarul NU este format din 2 cifre care se repeta");

        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
        /// </summary>
        private static void P18()
        {
            int n,d,p;
            Console.Write("Afisati descompunerea in factori primi ai unui numar n.\nIntroduceti o valoare pentru n: ");
            n = int.Parse(Console.ReadLine());
            d = 2; p = 0;
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }
                if (p > 0)
                    Console.Write($"{d}^{p} ");
                d ++;
                if (n > 1 && d * d > n)
                {
                    d = n;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        /// </summary>
        private static void P17()
        {
            int a, b, gcd=0, lcm=0,x,y,a1,b1;
            Console.Write("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.\nIntroduceti valorile pentru a si b: ");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            a1 = a; b1 = b;
            if (a < 0) a = -a;
            if (b < 0) b = -b;
            x = a; y = b;
            while (x != y)
            {
                if (x > y) x = x - y;
                else y = y - x;
            }

            /*while (x != 0)
            {
                r = y % x;
                y = x;
                x = r;
            }*/

            gcd = y;
            if (a < 0) a = -a;
            if (b < 0) b = -b;
            lcm = a*b/gcd;
            if (gcd == 1) Console.WriteLine($"{a1} si {b1} sunt prime intre ele, astfel cel mai mare divizor comun este 1, cel mai mic multiplu comun este: {lcm}");
            else
            Console.WriteLine($"Cel mai mare divizor comun a lui {a1} si {b1} este {gcd}, cel mai mic multiplu comun este: {lcm}");

        }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        private static void P16()
        {
            
        }

        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        private static void P15()
        {
            int a, b, c, aux;
            Console.Write("Se dau 3 numere. Sa se afiseze in ordine crescatoare.\nIntroduceti valorile pentru a,b si c:");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            c = int.Parse(v[2]);
            if (a > b)
            {
                aux = b;
                b = a;
                a = aux;
            }
            if (a > c)
            {
                aux = c;
                c = a;
                a = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine($"{a} {b} {c}");
        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
        /// </summary>
        private static void P14()
        {
            int n, inv = 0;

            Console.Write("Determianti daca un numar n este palindrom.\nIntroduceti o valoare pentru n :");
            n = int.Parse(Console.ReadLine());
            inv = inversa(n);
            if (n == inv)
                Console.WriteLine("Este palindrom");
            else
                Console.WriteLine("Nu este palindrom");
        }

        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void P13()
        {
            int a, b, nr = 0;
            Console.Write("Determianti cati ani bisecti sunt intre anii y1 si y2.\nIntroduceti primul si al doilea an:");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            for (int i = a + 1; i < b; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    nr++;
            }
            Console.WriteLine($"Numarul anilor bisecti intre anul {a} si {b} este: {nr}");
        }

        /// <summary>
        /// Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        private static void P12()
        {
            int a, b, n, nrdiv = 0;
            Console.Write("Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. \nIntroduceti valorile pentru n, a si b:");
            string[] v = Console.ReadLine().Split();
            n = int.Parse(v[0]);
            a = int.Parse(v[1]);
            b = int.Parse(v[2]);
            for (int i = a; i <= b; i++)
            {
                if (n % i == 0) nrdiv++;
            }
            Console.Write($"Numarul numerelor intregi divizibile cu {n} este {nrdiv}");
        }

        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n. 
        /// </summary>
        private static void P11()
        {
            int n, inv = 0;

            Console.Write("Afisati in ordine inversa cifrele unui numar n. \nIntroduceti o valoare pentru n :");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Ordinea inversa a lui {n} este ");
            inv = inversa(n);
            Console.WriteLine(inv);
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void P10()
        {
            int n;

            Console.Write("Determinati daca un numar n este prim.. \nIntroduceti o valoare pentru n :");
            n = int.Parse(Console.ReadLine());
            if (n == 1 || n == 0) Console.Write($"{n} nu este prim");
            if (n == 2) Console.Write($"{2} este prim");
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                { Console.WriteLine("Nu este prim"); return; }
            }
            Console.WriteLine("Este prim");
        }

        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        private static void P9()
        {
            int n;

            Console.Write("Afisati toti divizorii numarului n.  \nIntroduceti valorile pentru n :");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Divizorii lui {n} sunt:1 ");
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write($"{i} ");
            }

        }

        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
        /// </summary>
        private static void P8()
        {
            int a, b;
            Console.Write("Inversarea lui a si b (restrictionat) \nIntroduceti valorile pentru a si b:");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write($"Dupa inversare a = {a} si b = {b}");
        }
        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
        /// </summary>
        private static void P7()
        {
            int a, b, aux;
            Console.Write("Inversarea lui a si b  \nIntroduceti valorile pentru a si b:");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            aux = b;
            b = a;
            a = aux;
            Console.Write($"Dupa inversare a = {a} si b = {b}");

        }


        /// <summary>
        /// Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        private static void P6()
        {
            int a, b, c;
            Console.Write("Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.  \nIntroduceti valorile pentru a,b si c:");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            c = int.Parse(v[2]);
            if (a + b > c && a + c > b && b + c > a)
                Console.Write($"{a}, {b} si {c} pot fi lungimile laturilor unor triunghi");
            else
                Console.Write($"{a}, {b} si {c} NU pot fi lungimile laturilor unor triunghi");

        }

        /// <summary>
        /// Extrage si afiseaza a k-a cifra de la sfarsitul unui numar.
        private static void P5()
        {
            int n, k, i, cif = -1, n1;
            Console.Write("Extrage si afiseaza a k-a cifra de la sfarsitul unui numar. \nIntroduceti valorile pentru n si k:");
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
            if (cif == -1)
                Console.WriteLine($"Numarul k trebuie sa fie mai mic sau egal cu {n}!");
            else
                Console.WriteLine($"A {k}-a cifra a numarului {n1} este: {cif}");

        }

        /// <summary>
        /// Determina daca un an y este an bisect. 
        /// </summary>
        private static void P4()
        {
            int y;

            Console.Write("Determina daca un an y este an bisect.  \nIntroduceti valoarea pentru y:");
            string[] v = Console.ReadLine().Split();
            y = int.Parse(v[0]);
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                Console.WriteLine($"{y} este an bisect");
            else
                Console.WriteLine($"{y} NU este an bisect");
        }

        /// <summary>
        /// Determina daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        private static void P3()
        {
            int n, k;

            Console.Write("Determina daca n se divide cu k, unde n si k sunt date de intrare.  \nIntroduceti valorile pentru n si k:");
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

            Console.Write("Se rezolva o ecuatie de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0 \nIntroduceti valorile pentru a, b si c:");
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

            Console.Write("Se rezolva o ecuatie de gradul 1 cu o necunoscuta: ax+b = 0 \nIntroduceti valorile pentru a si b:");
            string[] v = Console.ReadLine().Split();
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            x = -b / a;
            if ((x * a + b) == 0)
                Console.WriteLine($"Rezolvarea lui x pentru ecuatia {a}x + {b} = 0 este: {x}");
            else
                Console.WriteLine($"Rezolvarea lui x pentru ecuatia {a}x + {b} = 0 este: -{b}/{a}");

        }

    }
}