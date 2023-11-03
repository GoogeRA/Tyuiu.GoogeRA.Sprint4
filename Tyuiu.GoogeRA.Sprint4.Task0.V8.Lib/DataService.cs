using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

//Дан одномерный целочисленный массив на 10 элементов заполненный
//статическими значениями в диапазоне от 0 до 9 подсчитать произведение
//четных элементов массива.  {1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}


namespace Tyuiu.GoogeRA.Sprint4.Task0.V8.Lib
{
    public class DataService : ISprint4Task0V8
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int SumArrey = 1;

            for (int i = 0; i <=array.Length - 1; i++ )
            {
                if ((array[i] % 2) == 0 )
                {
                    SumArrey = SumArrey * array[i];
                    
                }

            }
            return SumArrey;
            
        }
    }
}
