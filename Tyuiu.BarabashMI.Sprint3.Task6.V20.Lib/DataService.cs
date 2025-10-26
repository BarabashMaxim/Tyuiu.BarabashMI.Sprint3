﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BarabashMI.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        if (j < 12)
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
