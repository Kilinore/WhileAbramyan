using System;
using System.Collections.Specialized;

namespace MyWhileTasks
{
    public class MyWhileTasks
    {
        static void Main(string[] args)
        {
            return;
        }

        public int While1(int a, int b)
        {
            int numOfSegments = 0;
            while(a-b > 0)
            {
                a -= b;
                numOfSegments++;
            }
            return(numOfSegments);
        }

        static void While5()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while(n != 2)
            {
                n /= 2;
                k++;
            }
            Console.WriteLine(k);
        }

        static void While9()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int m = 3;
            int k = 1;
            while (n < m+1)
            {
                m *= 3;
                k++;
            }
            Console.WriteLine(k);
        }

        static void While13()
        {
            int A;
            A = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            double sum = 0;
            while(sum < A)
            {
                sum += 1.0 / k;
                k++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(--k);
        }

        static void While17()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                int k = n % 10;
                n = n / 10;
                Console.WriteLine(k);
            }
        }

        public string While21(int n)
        {
            while (n != 0)
            {
                int k = n % 10;
                n = n / 10;
                if(k % 2 == 1)
                {
                    return("TRUE");
                }
            }
            return("FALSE");
        }

        static void While25()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;
            while (true)
            {
                if(f1 > n)
                {
                    Console.WriteLine(f1);
                    break;
                }
                if (f2 > n)
                {
                    Console.WriteLine(f2);
                    break;
                }
                f1 = f1 + f2;
                f2 = f1 + f2;
            }
        }

        static void While29()
        {
            double E;
            E = Convert.ToDouble(Console.ReadLine());
            double Akm2 = 1;
            double Akm1 = 2;
            int k = 3;
            double Akm = (Akm2 + 2 * Akm1) / k;
            while (true)
            {
                if(Math.Abs(Akm - Akm1) < E)
                {
                    Console.WriteLine(k);
                    break;
                }
                Akm2 = Akm1;
                Akm1 = Akm;
                Akm = (Akm2 + 2 * Akm1) / k;
                k++;
            }
        }
    }
}
