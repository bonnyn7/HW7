// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

namespace Homework7
{
    class Task3
    {
        static int[,] array = {{3,2,7,1}, {4,2,8,3}, {9,1,6,2}};
        static float[] arrayAverage = new float[array.GetUpperBound(1) + 1];
        static void FindAverageOfSecondArray()
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                int i;
                for (i = 0; i <= array.GetUpperBound(0); i++)
                {
                    arrayAverage[j] += array[i,j];
                }
                arrayAverage[j] = arrayAverage[j] / (i);
            }
        }
        static void ViewAverage()
        {
            Console.Write("Среднее арифметическое каждого столбца: ");
            for (int i = 0; i < arrayAverage.Length; i++)
            {
                Console.Write("{0}; ", Math.Round(arrayAverage[i], 1));
            }
        }
        static void Main(string[] args)
        {
            FindAverageOfSecondArray();
            ViewAverage();
        }
    }
}