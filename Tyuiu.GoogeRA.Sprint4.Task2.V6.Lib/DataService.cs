﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GoogeRA.Sprint4.Task2.V6.Lib
{
    public class DataService : ISprint4Task2V6
    {
        public int Calculate(int[] array)
        {
            int SumArrey = 1;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if ((array[i] <= 8) && (array[i] >= 2))
                {
                    if ((array[i] % 2) != 0)
                    {
                        SumArrey = SumArrey * array[i];

                    }
                }
            }
            return SumArrey;
        }
    }
}
