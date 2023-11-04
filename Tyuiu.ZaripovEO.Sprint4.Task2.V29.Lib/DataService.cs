using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZaripovEO.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int sumArray = 1;
            int count = 0;
            int res = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray *= array[i];
                    count++;
                }
            }
            if (count == 0)
            {
                res = -1;
            }
            else
            {
                res = sumArray;
            }
            return res;
        }
    }
}
