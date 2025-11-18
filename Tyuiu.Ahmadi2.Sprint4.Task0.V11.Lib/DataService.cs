using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Ahmadi2.Sprint4.Task0.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;
            bool foundOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0) 
                {
                    product *= num;
                    foundOdd = true;
                }
            }

            return foundOdd ? product : 0; 
        }
    }
}