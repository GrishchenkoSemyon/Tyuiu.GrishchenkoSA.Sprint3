using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrishchenkoSA.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string result = "";
foreach (char c in value)
{
    if (char.IsDigit(c))
    {
        result += c;
    }
}
return Convert.ToInt32(result);
        }
    }
}
