using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoogeRA.Sprint4.Task7.V18.Lib;

namespace Tyuiu.GoogeRA.Sprint4.Task7.V18
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
            Console.WriteLine("* Задание #7                                                 *");
            Console.WriteLine("* Вариант #18                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 145258749635789.         *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте             *");
            Console.WriteLine("* произведение четных чисел.                                 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];

            string str = "145258749635789";

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
