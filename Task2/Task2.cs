// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;

namespace Homework7
{
    class Task2
    {
        static void RandomArray (int [,] array, int m, int n)
        {
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(10);
                    Console.Write(array[i, j]+"");
                }
                Console.WriteLine();
            }
        }
        static void PrintArray(int[,]array,int m,int n)
        {
            for (int rows=0; rows< m; rows++)
            {
                for (int columns=0;columns<n; columns++)
                {
                    Console.WriteLine($"{array[rows,columns]}");
                }
            }

        }
        static bool CheckElement(int [,] array, int a, int b)
        {
            if (a > -1 && a <= array.GetUpperBound(0) && 
                b > -1 && b <= array.GetUpperBound(1)) 
            return true;
            return false;
        }
        static void Solution (int[,]array, int a, int b)
        {
            if (CheckElement(a,b))
            {
                Console.WriteLine("Значение элемента [{0},{1}] = {2}", a, b, array[a,b]);
            }
            else
            {
                Console.WriteLine("Элементы [{0},{1}] не найдены", a, b);
            }

        }
        static void Main (string [] args)
        {
            Console.Write("Введите m: ");
            int m=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n=Convert.ToInt32(Console.ReadLine());
           
            int [,]array=new int[m,n];

            Console.WriteLine("Введите индекс #1 элемента массива:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс #2 элемента массива:");
            int b = Convert.ToInt32(Console.ReadLine());
            
            RandomArray(array,m,n);
            PrintArray(array, m, n);
            CheckElement(array,a,b);
            Solution(array,a,b);
            Console.WriteLine();
        }
    }
}