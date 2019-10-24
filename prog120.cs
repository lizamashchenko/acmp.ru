/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmp.ru
{
    class prog120
    {
        static void Main()
        {
            Pr120();
        }

        static void Pr120()
        {

            Random r = new Random();
            int m = 3;
            int n = 4;
            int [,]a = new int[m, n];
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    a[i, j] = r.Next(200);
                }
            }
            int[,] b = new int[m, n];



            for (int j = 2; j < n; j++)
            {
                b[1, j] = a[1, j] + b[1, j - 1];
            }
            for (int i = 2; i < m; i++)
            {
                b[i, 1] = a[i, 1] + b[i - 1, 1];
            }



            for (int i = 2; i < m; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    if (b[i, j - 1] <= b[i - 1, j]) b[i, j] = a[i, j] + b[i, j - 1];
                    else b[i, j] = a[i, j] + b[i - 1, j];
                }
            }
            Console.WriteLine(b[m, n]);
        }
    }
}*/
