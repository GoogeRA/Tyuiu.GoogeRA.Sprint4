using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GoogeRA.Sprint4.Task3.V19.Lib
{
    public class DataService : ISprint4Task3V19
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; // количество строк
            int colums = array.Length / rows; //количестов столбцов

            int count = 0;

            for(int i = 0; i < rows; i++)
            {
                    for (int j = 0; j < colums; j++)
                    {
                        if ((array[i, j] <= 9) && (array[i, j] >= 3))
                        {
                            if ((array[i, j] % 2) == 0)
                            {
                            count++;
                            }
                        }
                    }
                
            }
            return count;
        }
    }
}
