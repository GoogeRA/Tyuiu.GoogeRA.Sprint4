using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoogeRA.Sprint4.Task1.V23.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)              *");
            Console.WriteLine("* Задание #1                                                 *");
            Console.WriteLine("* Вариант #23                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов        *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до 9  *");
            Console.WriteLine("* подсчитать сумму четных элементов массива.                 *");
            Console.WriteLine("* {9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9}        *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int len;

            Console.WriteLine(" Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + "элемента массива: ");
                numsArry[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            int res = ds.Calculate(numsArry);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
