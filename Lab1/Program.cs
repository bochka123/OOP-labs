using System;
/*
 * Oleksandr Tkach
 * number of the score book - 328
 * C2 - 0
 * C3 - 1 
 * C5 - 3
 * C7 - 6
 */
namespace OOP
{
    internal class Lab1
    {
        static void Main(string[] args)
        {
            int C3 = 1;
            double s = 0, temp;
            Console.Write("Enter A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter N: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            double m = double.Parse(Console.ReadLine());
            if (a > n)
            {
                temp = a;
                a = n;
                n = temp;
            }
            if (b > m)
            {
                temp = b;
                b = m;
                m = temp;
            }
            if (a <= -C3 && n >= -C3)
            {
                Console.WriteLine("Division by 0 takes place");
                return;
            }
            for (double i = a; i <= n; i++)
            {
                for (double j = b; j <= m; j++)
                {
                    s += (i + j) / (i + C3);
                }
            }
            Console.WriteLine($"Result: {s}");
        }
    }
}
