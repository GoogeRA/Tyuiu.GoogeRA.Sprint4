﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoogeRA.Sprint4.Task5.V5.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема:    Двумерные массивы. (генератор случайных чисел)    *");
            Console.WriteLine("* Задание #5                                                 *");
            Console.WriteLine("* Вариант #5                                                 *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов        *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -5 до 8   *");
            Console.WriteLine("* Найти сумму положительных элементов.                       *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("Введите кол-во строк в массиве");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите кол-во стобцов в массиве");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd.Next(-5, 8);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");


            int res = ds.Calculate(mtrx);
            Console.WriteLine("сумму положительных элементов " + res);
            Console.ReadKey();
        }
    }
}
