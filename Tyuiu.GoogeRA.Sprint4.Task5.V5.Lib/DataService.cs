using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GoogeRA.Sprint4.Task5.V5.Lib
{
    public class DataService : ISprint4Task5V5
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int colums = matrix.Length / rows; //количестов столбцов
            int SumArrey = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if ((matrix[i, j] <= 8) && (matrix[i, j] >= -5))
                    {
                        if (matrix[i, j] > 0)
                        {
                            SumArrey = SumArrey + matrix[i, j];
                        }
                    }
                }

            }
            return SumArrey;





            
        }
    }
}
