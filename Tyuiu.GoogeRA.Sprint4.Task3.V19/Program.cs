using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint4.Task3.V19.Lib;

//от 3 до 9. Подсчитайте количество четных элементов во всем массиве.

namespace Tyuiu.GoogeRA.Sprint4.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема:    Двумерные массивы. (статический ввод)             *");
            Console.WriteLine("* Задание #3                                                 *");
            Console.WriteLine("* Вариант #19                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов        *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 3 до 9  *");
            Console.WriteLine("* подсчитать количество четных элементов массива.            *");
            Console.WriteLine("* {9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9}        *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Массив:");

            int[,] mtrx = new int[5, 5] { { 6, 5, 6, 3, 8,},
                                          { 9, 4, 4, 3, 4,},
                                          { 3, 3, 6, 8, 6,},
                                          { 6, 5, 3, 4, 3,},
                                          { 9, 3, 5, 3, 7,}, };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for ( int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
