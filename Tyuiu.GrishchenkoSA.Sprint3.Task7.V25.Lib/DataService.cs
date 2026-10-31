using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
double[] valueArray = new double[len];
int index = 0;
for (int x = startValue; x <= stopValue; x++)
{
    double denominator = 2;
    if (denominator == 0)
    {
        valueArray[index] = 0.0;
    }
    else
    {
        double y = Math.Cos(x) + ((4.0 * x) / denominator) - (Math.Sin(x) * (3.0 * x));
        valueArray[index] = Math.Round(y, 2);
    }
    index++;
}
return valueArray;
        }
    }
}
