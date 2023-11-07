using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GoogeRA.Sprint4.Task4.V24.Lib
{
    public class DataService : ISprint4Task4V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int colums = matrix.Length / rows; //количестов столбцов

            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if ((matrix[i, j] <= 9) && (matrix[i, j] >= 5))
                    {
                        if ((matrix[i, j] % 2) == 0)
                        {
                            matrix[i, j] = 1;
                        }
                    }
                }

            }
            return matrix; 
        }
    }
}
