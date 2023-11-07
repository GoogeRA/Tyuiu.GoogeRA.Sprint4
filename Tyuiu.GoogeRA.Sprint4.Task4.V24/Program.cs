using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint4.Task4.V24.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема:    Двумерные массивы. (ввод с клавиатуры)            *");
            Console.WriteLine("* Задание #4                                                 *");
            Console.WriteLine("* Вариант #24                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов        *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 5 до 9  *");
            Console.WriteLine("* Заменить четные элементы массива на 1.                     *");
            Console.WriteLine("* { 7, 9, 7, 6, 7,}                                          *");
            Console.WriteLine("* { 9, 9, 8, 6, 7,}                                          *");
            Console.WriteLine("* { 8, 6, 5, 6, 7,}                                          *");
            Console.WriteLine("* { 9, 9, 7, 8, 7,}                                          *");
            Console.WriteLine("* { 5, 9, 9, 8, 9,}                                          *");
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
                    Console.Write($" Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
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

           
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
