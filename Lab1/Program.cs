using System;
/*
Oleksndr Tkach
number of the score book - 328
C2 - 0
C3 - 1 
C5 - 3
C7 - 6
*/
namespace OOP
{
    internal class Lab1
    {
        static void Main(string[] args)
        {
            int C3 = 1;
            double s = 0, a = 2, b = 3, n = 9, m = 10;
            for (double i = a; i <= n; i++)
            {
                for (double j = b; j <= m; j++)
                {
                    s += (i + j) / (i + C3);
                }
            }
            Console.WriteLine(s);
        }
    }
}
