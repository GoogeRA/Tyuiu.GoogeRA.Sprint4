using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint4.Task0.V8.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task0.V8
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту    *");
            Console.WriteLine("* Задание #0                                                 *");
            Console.WriteLine("* Вариант #8                                                 *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов        *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9  *");
            Console.WriteLine("* подсчитать произведение четных элементов массива.          *");
            Console.WriteLine("* {1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}                             *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int[] numsArrey = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

            Console.WriteLine("Исходжне данные");
            for (int i = 0; i <= numsArrey.Length - 1; i++)
            {
                Console.WriteLine(numsArrey[i]);
                
            }
                
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            int sumArray;
            sumArray = ds.GetMultEvenArrEl(numsArrey); 

            for (int i = 0; i <= numsArrey.Length - 1; i++) 
            {
                Console.WriteLine(sumArray + "\t");
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
