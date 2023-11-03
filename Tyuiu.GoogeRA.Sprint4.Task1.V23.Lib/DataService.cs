using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoogeRA.Sprint4.Task1.V23.Lib
{
    public class DataService : ISprint4Task1V23
    {
        public int Calculate(int[] array)
        {
            int SumArrey = 0;

            for (int i = 0;   i <= array.Length - 1; i++)
            {
                if ((array[i] >= 9) || (array[i] >= 4))
                {
                    if ((array[i] % 2) == 0)
                    {
                        SumArrey += array[i];

                    }
                }
            }
            return SumArrey;

        }
    }
}
