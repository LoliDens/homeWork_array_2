using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] numbers = new int[10, 10];
            int lowerLimitRandom = 0;
            int upperLimitRandom = 100;
            int maxElemetInArrray = lowerLimitRandom;
            int replecementNumber = 0;

            for (int i = 0; i < numbers.GetLength(0); i++) 
            {
                for (int j = 0; j < numbers.GetLength(1); j++) 
                {
                    numbers[i, j] = random.Next(lowerLimitRandom, upperLimitRandom + 1);
                }
            }

            Console.WriteLine("Исходная матрица :\n");
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (maxElemetInArrray < numbers[i, j]) 
                    {
                        maxElemetInArrray = numbers[i, j];
                    }
                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (maxElemetInArrray == numbers[i, j]) 
                    {
                        numbers[i, j] = replecementNumber;
                    }
                }
            }

            Console.WriteLine($"\nМаксимальный элемент в матрице равене {maxElemetInArrray}");
            Console.WriteLine($"Измененная матрица, где максимальный элемент заменили на {replecementNumber}: \n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
