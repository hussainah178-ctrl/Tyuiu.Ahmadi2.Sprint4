using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Ahmadi2.Sprint4.Task1.V22.Lib
{
    public class DataService : ISprint4Task1V22
    {
        public int Calculate(int[] array)
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