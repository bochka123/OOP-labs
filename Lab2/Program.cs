using System;
/*
 * Oleksandr Tkach
 * number of the score book - 328
 * C5 - 3
 * C7 - 6
 * C11 - 9
 */
namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] A = {
                {4.3f, 9.6f, 10.0f},
                {2.2f, 2.4f, 1.0f},
                {2.6f, 9.8f, 2.6f}};
            float[,] B = {
                {5.3f, 8.2f, 15.3f},
                {3.2f, 1.5f, 2.4f},
                {2.7f, 11.7f, 13.5f}};
            float[,] C = new float[A.GetLength(0),A.GetLength(1)];
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i,j] = (int)A[i,j] ^ (int)B[i,j];
                    Console.Write($"{C[i,j]}\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < C.GetLength(0); i++)
            {
                float sum = 0;
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    sum += C[j, i];
                }
                float avg = sum / 3;
                Console.WriteLine($"Середнє значення {i + 1}-ого стовпця:\t {avg}");
            }
        }
    }
}
