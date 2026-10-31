using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
for (int i = startValue1; i <= stopValue1; i++)
{
    for (int k = startValue2; k <= stopValue2; k++)
    {
        sum += Math.Pow(x, k) + Math.Cos(k);
    }
}
return Math.Round(sum, 3);
        }
    }
}
