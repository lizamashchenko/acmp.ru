using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _329
{
    class Program
    {
        static void Main()
        {
            Pr329();
        }
        static void Pr329()
        {
            int N = 5;
            Random r = new Random();
            int[] a = new int[N];
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1000) - r.Next(1000);
                Console.Write(a[i] + ' ');
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Console.Write(i + ' ');
                    sum = sum + a[i];
                }
                else if (a[i] < 0 && a[i + 1] < 0)
                {
                    if (a[i] < a[i + 1])
                    {
                        Console.Write(i + ' ');
                        sum = sum + a[i];
                    }
                    else
                    {
                        i++;
                        Console.WriteLine(i + ' ');
                        sum = sum + a[i];
                    }
                }
                else
                {
                    i++;
                    Console.Write(i);
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Sum" + sum);
        }
    }
}

