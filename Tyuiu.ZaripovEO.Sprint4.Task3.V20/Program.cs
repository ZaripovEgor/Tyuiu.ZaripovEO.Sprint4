using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZaripovEO.Sprint4.Task3.V20.Lib;

namespace Tyuiu.ZaripovEO.Sprint4.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5] { { 8, 7, 7, 8, 5}, { 4, 3, 5, 3, 6}, { 5, 3, 8, 6, 3}, { 6, 3, 8, 5, 4}, { 3, 6, 8, 3, 4} };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт №4 | Выполнил: Зарипов Е. О. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Зарипов Егор Олегович | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8.                          *");
            Console.WriteLine("* Найдите минимальный элемент в первом столбце массива.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");

            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(matrix);

            Console.WriteLine("Минимальный элемент в первом столбце: " + res);
            Console.ReadKey();
        }
    }
}
